using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Test13_6
{
    public partial class Test13_6 : Form
    {
        public Test13_6()
        {
            InitializeComponent();
        }

        private MailMessage CreateMail(MailAddress from,MailAddress to,string subject,string body,List<string> attachFiles)
        {
            MailMessage message = new MailMessage(from, to);
            message.SubjectEncoding = System.Text.Encoding.UTF8;
            message.Subject = subject;
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.Body = body;
            //添加附件
            for (int i = 0; i < attachFiles.Count; i++)
            {
                Attachment attachFile = new Attachment( attachFiles[i]);
                message.Attachments.Add(attachFile);
            }
            return message;

        }
        //根据指定的参数发送邮件
        private void SendMail(MailAddress from, string password,MailMessage message)
        {
            //不使用默认凭证,注意此句必须放在client.Credentials的上面
            SmtpClient client = new SmtpClient("smtp." + from.Host);
            client.UseDefaultCredentials = false;
            //指定用户名、密码
            client.Credentials = new NetworkCredential(from.Address, password);
            //邮件通过网络发送到服务器
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            try
            {
                client.Send(message);
            }
            catch(SmtpException ex)
            {
                MessageBox.Show("发送失败，详细原因请参考：\n"+ex.Message,"警告");
            }
            finally
            {
                //及时释放占用的资源
                message.Dispose();
            }
        }
        //单击【添加附件】按钮触发的事件
        private void btnAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.CheckFileExists = true;
            //只接收有效的文件名
            openfile.ValidateNames = true;
            //允许一次选择多个文件作为附件
            openfile.Multiselect = true;
            openfile.ShowDialog();
            if (openfile.FileNames.Length > 0)
            {
                listBox1.Items.AddRange(openfile.FileNames);
            }
        }
        //单击【发送】按钮触发的事件
        private void btnSend_Click(object sender, EventArgs e)
        {

            //发件人和收件人地址
            MailAddress from = new MailAddress(txtUser.Text);
            MailAddress to = new MailAddress(txtReceive.Text);
            //邮件主题、内容
            string subject = txtSubject.Text;
            string body = txtBody.Text;
            List<string> attachFiles = new List<String>();
            //最多添加10个附件
            for (int i = 0; i < listBox1.Items.Count && i < 10; i++)
            {
                if (listBox1.Items[i].ToString() != String.Empty)
                {
                    attachFiles.Add(listBox1.Items[i].ToString());
                }
            }
            MailMessage message = CreateMail(from, to, subject, body, attachFiles);
            //注意，本例适合以smtp.前缀的邮件服务器
            SendMail(from, txtPassword.Text, message);
            MessageBox.Show("发送成功");
        }
    } 
}
