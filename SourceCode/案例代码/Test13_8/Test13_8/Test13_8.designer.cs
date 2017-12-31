namespace Test13_8
{
    partial class Test13_8
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFtpUri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnConnection = new System.Windows.Forms.Button();
            this.btnDownLoad = new System.Windows.Forms.Button();
            this.btnChangDir = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.chkAnonymous = new System.Windows.Forms.CheckBox();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnFileUp = new System.Windows.Forms.Button();
            this.grpLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "FTP服务器地址：";
            // 
            // txtFtpUri
            // 
            this.txtFtpUri.Location = new System.Drawing.Point(107, 9);
            this.txtFtpUri.Name = "txtFtpUri";
            this.txtFtpUri.Size = new System.Drawing.Size(168, 21);
            this.txtFtpUri.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "端口：";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(343, 9);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(41, 21);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "21";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "用户名：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(58, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(71, 21);
            this.txtName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "密码：";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(189, 13);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(74, 21);
            this.txtPwd.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(15, 79);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(266, 112);
            this.listBox1.TabIndex = 4;
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(303, 79);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(75, 23);
            this.btnConnection.TabIndex = 5;
            this.btnConnection.Text = "连接";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // btnDownLoad
            // 
            this.btnDownLoad.Location = new System.Drawing.Point(303, 137);
            this.btnDownLoad.Name = "btnDownLoad";
            this.btnDownLoad.Size = new System.Drawing.Size(75, 23);
            this.btnDownLoad.TabIndex = 5;
            this.btnDownLoad.Text = "下载";
            this.btnDownLoad.UseVisualStyleBackColor = true;
            this.btnDownLoad.Click += new System.EventHandler(this.btnDownLoad_Click);
            // 
            // btnChangDir
            // 
            this.btnChangDir.Location = new System.Drawing.Point(303, 109);
            this.btnChangDir.Name = "btnChangDir";
            this.btnChangDir.Size = new System.Drawing.Size(75, 23);
            this.btnChangDir.TabIndex = 5;
            this.btnChangDir.Text = "更换目录";
            this.btnChangDir.UseVisualStyleBackColor = true;
            this.btnChangDir.Click += new System.EventHandler(this.btnChangDir_Click);
            // 
            // chkAnonymous
            // 
            this.chkAnonymous.AutoSize = true;
            this.chkAnonymous.Location = new System.Drawing.Point(15, 44);
            this.chkAnonymous.Name = "chkAnonymous";
            this.chkAnonymous.Size = new System.Drawing.Size(96, 16);
            this.chkAnonymous.TabIndex = 6;
            this.chkAnonymous.Text = "是否匿名访问";
            this.chkAnonymous.UseVisualStyleBackColor = true;
            this.chkAnonymous.Click += new System.EventHandler(this.chkAnonymous_Click);
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.txtName);
            this.grpLogin.Controls.Add(this.label3);
            this.grpLogin.Controls.Add(this.txtPwd);
            this.grpLogin.Controls.Add(this.label4);
            this.grpLogin.Location = new System.Drawing.Point(126, 29);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(272, 39);
            this.grpLogin.TabIndex = 7;
            this.grpLogin.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnFileUp
            // 
            this.btnFileUp.Location = new System.Drawing.Point(303, 166);
            this.btnFileUp.Name = "btnFileUp";
            this.btnFileUp.Size = new System.Drawing.Size(75, 23);
            this.btnFileUp.TabIndex = 8;
            this.btnFileUp.Text = "上传";
            this.btnFileUp.UseVisualStyleBackColor = true;
            this.btnFileUp.Click += new System.EventHandler(this.btnFileUp_Click);
            // 
            // Test13_8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 201);
            this.Controls.Add(this.btnFileUp);
            this.Controls.Add(this.grpLogin);
            this.Controls.Add(this.chkAnonymous);
            this.Controls.Add(this.btnChangDir);
            this.Controls.Add(this.btnDownLoad);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFtpUri);
            this.Controls.Add(this.label1);
            this.Name = "Test13_8";
            this.Text = "简易FTP客户端";
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFtpUri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Button btnDownLoad;
        private System.Windows.Forms.Button btnChangDir;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox chkAnonymous;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnFileUp;
    }
}