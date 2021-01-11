using System;
using System.Collections;
using System.Configuration;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;


public abstract class MySqlHelper
{
    //数据库连接字符串
    public static string Conn = "Database='Hotel_Management';Data Source='localhost';User Id='root';Password='root';charset='utf8';pooling=true";


    public static MySqlDataReader ExecuteReader(string cmdText, params MySqlParameter[] commandParameters)
    {
        return ExecuteReader(Conn, CommandType.Text, cmdText, commandParameters);
    }

    public static DataSet GetDataSet(string cmdText, params MySqlParameter[] commandParameters)
    {
        return GetDataSet(Conn, CommandType.Text, cmdText, commandParameters);
    }

    public static int ExecuteNonQuery(string cmdText, params MySqlParameter[] commandParameters)
    {
        return ExecuteNonQuery(Conn, CommandType.Text, cmdText, commandParameters);
    }

    private static Hashtable parmCache = Hashtable.Synchronized(new Hashtable());

    public static int ExecuteNonQuery(string connectionString, CommandType cmdType, string cmdText, params MySqlParameter[] commandParameters)
    {

        MySqlCommand cmd = new MySqlCommand();

        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
            int val = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            return val;
        }
    }


    public static int ExecuteNonQuery(MySqlConnection connection, CommandType cmdType, string cmdText, params MySqlParameter[] commandParameters)
    {

        MySqlCommand cmd = new MySqlCommand();

        PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters);
        int val = cmd.ExecuteNonQuery();
        cmd.Parameters.Clear();
        return val;
    }


    public static int ExecuteNonQuery(MySqlTransaction trans, CommandType cmdType, string cmdText, params MySqlParameter[] commandParameters)
    {
        MySqlCommand cmd = new MySqlCommand();
        PrepareCommand(cmd, trans.Connection, trans, cmdType, cmdText, commandParameters);
        int val = cmd.ExecuteNonQuery();
        cmd.Parameters.Clear();
        return val;
    }
    public static MySqlDataReader ExecuteReader(string connectionString, CommandType cmdType, string cmdText, params MySqlParameter[] commandParameters)
    {
        //创建一个MySqlCommand对象
        MySqlCommand cmd = new MySqlCommand();
        //创建一个MySqlConnection对象
        MySqlConnection conn = new MySqlConnection(connectionString);
        try
        {
            //调用 PrepareCommand 方法，对 MySqlCommand 对象设置参数
            PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
            //调用 MySqlCommand  的 ExecuteReader 方法
            MySqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            //清除参数
            cmd.Parameters.Clear();
            return reader;
        }
        catch(Exception e)
        {
            //关闭连接，抛出异常
            conn.Close();
            Debug.Write(e.Message);
            throw;
        }
    }
    public static DataSet GetDataSet(string connectionString, CommandType cmdType, string cmdText, params MySqlParameter[] commandParameters)
    {
        //创建一个MySqlCommand对象
        MySqlCommand cmd = new MySqlCommand();
        //创建一个MySqlConnection对象
        MySqlConnection conn = new MySqlConnection(connectionString);
        try
        {
            //调用 PrepareCommand 方法，对 MySqlCommand 对象设置参数
            PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
            //调用 MySqlCommand  的 ExecuteReader 方法
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataSet ds = new DataSet();

            adapter.Fill(ds);
            //清除参数
            cmd.Parameters.Clear();
            conn.Close();
            return ds;
        }
        catch (Exception e)
        {
            throw e;
        }
    }


    public static object ExecuteScalar(string connectionString, CommandType cmdType, string cmdText, params MySqlParameter[] commandParameters)
    {
        MySqlCommand cmd = new MySqlCommand();

        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters);
            object val = cmd.ExecuteScalar();
            cmd.Parameters.Clear();
            return val;
        }
    }

    public static object ExecuteScalar(MySqlConnection connection, CommandType cmdType, string cmdText, params MySqlParameter[] commandParameters)
    {

        MySqlCommand cmd = new MySqlCommand();

        PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters);
        object val = cmd.ExecuteScalar();
        cmd.Parameters.Clear();
        return val;
    }


    public static void CacheParameters(string cacheKey, params MySqlParameter[] commandParameters)
    {
        parmCache[cacheKey] = commandParameters;
    }


    public static MySqlParameter[] GetCachedParameters(string cacheKey)
    {
        MySqlParameter[] cachedParms = (MySqlParameter[])parmCache[cacheKey];

        if (cachedParms == null)
            return null;

        MySqlParameter[] clonedParms = new MySqlParameter[cachedParms.Length];

        for (int i = 0, j = cachedParms.Length; i < j; i++)
            clonedParms[i] = (MySqlParameter)((ICloneable)cachedParms[i]).Clone();

        return clonedParms;
    }


    private static void PrepareCommand(MySqlCommand cmd, MySqlConnection conn, MySqlTransaction trans, CommandType cmdType, string cmdText, MySqlParameter[] cmdParms)
    {

        if (conn.State != ConnectionState.Open)
            conn.Open();

        cmd.Connection = conn;
        cmd.CommandText = cmdText;

        if (trans != null)
            cmd.Transaction = trans;

        cmd.CommandType = cmdType;

        if (cmdParms != null)
        {
            foreach (MySqlParameter parm in cmdParms)
                cmd.Parameters.Add(parm);
        }
    }

}