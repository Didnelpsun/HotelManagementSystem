using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelManagementUI.System_
{
    public partial class FormPsModify : Form
    {
        string _name;
        public FormPsModify(string name)
        {
            InitializeComponent();
            _name = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text.ToString().Trim();
            if (text.Length < 6)
            {
                MessageBox.Show("密码应大于6位！");
                return;
            }
            HotelManagementBLL.User.ModifyPs(_name, text);
        }
    }
}
