using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Web;

namespace Test13_3
{
    public partial class Test13_3 : Form
    {
        public Test13_3()
        {
            InitializeComponent();
        }

        private string DoSocketGet(string request, IPAddress address)
        {
            Encoding utf8 = Encoding.UTF8;  //指定编码集
            Byte[] messages = utf8.GetBytes(request);
            Byte[] receives = new Byte[1024];   //用于缓存接收到的数据
            String result = null;
            try
            {         
                int port = 80;                  //指定端口号
                IPEndPoint endPoint = new IPEndPoint(address, port);//定义套接字的端点
                Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                s.Connect(endPoint);    //从本地连接远程端点
                if (!s.Connected)
                {
                    result = "不能连接远程服务器";
                }
                s.Send(messages, messages.Length, 0);                  //发送HTTP请求
                Int32 bytes = s.Receive(receives, receives.Length, 0);  //接收HTTP响应
                result = utf8.GetString(receives, 0, bytes);   //将HTTP响应的字节流转换为字符串
            }

            catch (SocketException e)
            {
                MessageBox.Show("Source:" + e.Source + "\nMessage: " + e.Message, "套接字错误", MessageBoxButtons.OK);
            }
            return result;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            string server = txtUri.Text;
            string request = "GET / HTTP/1.1\r\nHost: " + server +
                "\r\nConnection: Close\r\n\r\n";
            IPHostEntry hostInfo = Dns.GetHostEntry(server);
            IPAddress address = null;
            if (hostInfo.AddressList.Length > 0)
                address = hostInfo.AddressList[0];
            txtShow.Text = DoSocketGet(request,address);     
        }
    }
}
