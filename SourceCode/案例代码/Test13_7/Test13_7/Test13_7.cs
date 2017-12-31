using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Test13_7
{
    public partial class Test13_7 : Form
    {
        private Pop3Helper _pop3Helper;
        public Test13_7()
        {
            InitializeComponent();
        }

        private void showMailList()
        {
            int count = _pop3Helper.GetMailCount(); ;
            lstEmails.Items.Clear();
            if (count > 0)
            {

                btnRead.Enabled = true;   //显示“阅读邮件”按钮
                btnDelete.Enabled = true; //显示“删除邮件”按钮
                for (int i = 0; i < count; i++)
                {
                    lstEmails.Items.Add(string.Format("第{0}封邮件", i + 1));
                }
            }
            else
            {
                groupBoxOperation.Text = "信箱中没有邮件";
                btnRead.Enabled = false;
                btnDelete.Enabled = false;
            }
            lstEmails.SelectedIndex = 0;
            //设置鼠标光标为默认光标
            Cursor.Current = Cursors.Default;
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.Text == "连接服务器")
            {
                btnConnect.Text = "断开服务器";
                //设置鼠标光标为等待状态
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    int index = txtUser.Text.IndexOf('@');
                    //大部分pop3服务器都加前缀pop3.，这里仅获取这种服务器
                    //对不以pop3.为前缀的情况，这个例子未进行处理
                    string server = "pop3." + txtUser.Text.Substring(index + 1);
                    //建立与POP3服务器的连接，使用默认端口110
                    _pop3Helper = new Pop3Helper(server, 110, txtUser.Text, txtPassword.Text);
                    _pop3Helper.Connect();
                }
                catch
                {
                    MessageBox.Show("与服务器连接失败");
                    return;
                }
                showMailList();
            }
            else
            {
                btnConnect.Text="连接服务器";
                _pop3Helper.Close();
                lstEmails.Items.Clear();
                rtxtContent.Clear();
            }
        }
 

        //单击阅读信件按钮触发的事件
        private void btnRead_Click(object sender, EventArgs e)
        {
            //设置鼠标光标为等待状态
            Cursor.Current = Cursors.WaitCursor;
            rtxtContent.Text = _pop3Helper.GetMail(lstEmails.SelectedIndex+1);
            lstEmails.Items[lstEmails.SelectedIndex] += "，共" + rtxtContent.Text.Length.ToString() + "字节";
            //设置鼠标光标为默认光标
            Cursor.Current = Cursors.Default;
        }
        //单击删除信件按钮触发的事件
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string str = lstEmails.SelectedItem.ToString();
            int j = lstEmails.SelectedIndex + 1;
            _pop3Helper.DeleteMail(j);
            _pop3Helper.Close();
            _pop3Helper.Connect();
            showMailList();
        }      
    }
 
}
