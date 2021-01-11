namespace HotelManagementUI.CheckIn
{
    partial class FormCheckOut
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheckOut));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIDCard = new System.Windows.Forms.TextBox();
            this.textBoxRoomName = new System.Windows.Forms.TextBox();
            this.radioButtonRoomName = new System.Windows.Forms.RadioButton();
            this.radioButtonIDCard = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "身份证号：";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(41, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "房间名：";
            // 
            // textBoxIDCard
            // 
            this.textBoxIDCard.Location = new System.Drawing.Point(142, 51);
            this.textBoxIDCard.Name = "textBoxIDCard";
            this.textBoxIDCard.Size = new System.Drawing.Size(100, 21);
            this.textBoxIDCard.TabIndex = 6;
            // 
            // textBoxRoomName
            // 
            this.textBoxRoomName.Location = new System.Drawing.Point(142, 84);
            this.textBoxRoomName.Name = "textBoxRoomName";
            this.textBoxRoomName.Size = new System.Drawing.Size(100, 21);
            this.textBoxRoomName.TabIndex = 7;
            // 
            // radioButtonRoomName
            // 
            this.radioButtonRoomName.AutoSize = true;
            this.radioButtonRoomName.Location = new System.Drawing.Point(162, 139);
            this.radioButtonRoomName.Name = "radioButtonRoomName";
            this.radioButtonRoomName.Size = new System.Drawing.Size(59, 16);
            this.radioButtonRoomName.TabIndex = 9;
            this.radioButtonRoomName.TabStop = true;
            this.radioButtonRoomName.Text = "房间名";
            this.radioButtonRoomName.UseVisualStyleBackColor = true;
            // 
            // radioButtonIDCard
            // 
            this.radioButtonIDCard.AutoSize = true;
            this.radioButtonIDCard.Location = new System.Drawing.Point(59, 139);
            this.radioButtonIDCard.Name = "radioButtonIDCard";
            this.radioButtonIDCard.Size = new System.Drawing.Size(59, 16);
            this.radioButtonIDCard.TabIndex = 8;
            this.radioButtonIDCard.TabStop = true;
            this.radioButtonIDCard.Text = "身份证";
            this.radioButtonIDCard.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "办理退房";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButtonRoomName);
            this.Controls.Add(this.radioButtonIDCard);
            this.Controls.Add(this.textBoxRoomName);
            this.Controls.Add(this.textBoxIDCard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCheckOut";
            this.Text = "退房管理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIDCard;
        private System.Windows.Forms.TextBox textBoxRoomName;
        private System.Windows.Forms.RadioButton radioButtonRoomName;
        private System.Windows.Forms.RadioButton radioButtonIDCard;
        private System.Windows.Forms.Button button1;
    }
}