using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Test13_4
{
    public partial class Test13_4_S : Form
    {
        static TcpClient client = null;  //客户端对象，用来接收或发送消息
        static NetworkStream stream = null;  //流对象，完成接收或发送消息操作      
        TcpListener server = null;       //监听器对象，用来监听TCP连接

        public Test13_4_S()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int port = Convert.ToInt32(txtPort.Text);
            IPEndPoint p = new IPEndPoint(IPAddress.Any, port);  //创建TCP连接的端点
            server = new TcpListener(p);       //初始化TcpListener的新实例
            server.Start();                    // 开始监听客户端的请求.
            lstShow.Items.Add("服务器已启动!");
            client = server.AcceptTcpClient();  //执行挂起和接受客户端的连接请求
            lstShow.Items.Add("已连接客户端!");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] msg = Encoding.UTF8.GetBytes(txtMessage.Text);
            stream = client.GetStream();  // 获取用于读取和写入的流对象
            stream.Write(msg, 0, msg.Length); // 发回一个响应消息.
        }
         private void btnAccept_Click(object sender, EventArgs e)
        {
            Byte[] bytes = new Byte[256];            //缓存读入的数据
            stream = client.GetStream();  // 获取用于读取和写入的流对象
            stream.Read(bytes, 0, bytes.Length);
            string data = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
            lstShow.Items.Add("客户端: " + data);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if(stream!=null) stream.Close();
            if(client!=null) client.Close();
            if(server!=null) server.Stop();
        }
    }
}
