using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Test13_4_C
{
    public partial class Test13_4_C : Form
    {
        static TcpClient client = null;
        static NetworkStream stream = null;
        public Test13_4_C()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string strIp = txtAddress.Text;
            int port = Convert.ToInt32(txtPort.Text);
            client = new TcpClient();     //创建TCP客户端
            client.Connect(strIp, port);  //连接服务器
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //把message转换成UTF编码的字节数组。
            Byte[] data = Encoding.UTF8.GetBytes(txtMessage.Text);
            stream = client.GetStream();        // 获取用于读取和写入的流对象
            stream.Write(data, 0, data.Length); // 将消息发送到服务器
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            stream = client.GetStream();        // 获取用于读取和写入的流对象
            Byte[] data = new Byte[1024];     // 接爱服务器的响应.
            String responseData = String.Empty;
            int bytes = stream.Read(data, 0, data.Length);
            responseData = Encoding.UTF8.GetString(data, 0, bytes);
            lstShow.Items.Add("服务器: " + responseData);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (stream != null) stream.Close();
            if (client != null) client.Close();
        }
    }
}
