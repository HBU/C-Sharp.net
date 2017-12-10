using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Test_13_5_R
{
    public partial class Test13_5_R : Form
    {
        delegate void AppendStringCallback(string text);  //定义委托
        AppendStringCallback onAppendStringCallback;      //定义回调事件
        private UdpClient client;                         //定义Udp客户端对象
        public Test13_5_R()
        {
            InitializeComponent();
            onAppendStringCallback = new AppendStringCallback(AppendString);  //绑定事件
        }
        private void AppendString(string text)  //定义事件方法
        {
            //Windows 窗体中的控件被绑定到特定的线程，不具备线程安全性。
            //因此，如果从另一个线程调用控件的方法，那么必须使用控件的一个 Invoke 方法来将调用封送到适当的线程。
            //InvokeRequired属性用于确定是否必须调用 Invoke 方法。
            if (txtReceive.InvokeRequired)
                this.Invoke(onAppendStringCallback, text);//触发事件，执行在另一个线程中订阅事件方法
            else 
                txtReceive.AppendText(text + "\r\n");
        }

        private void ReceiveData()
        {
            client = new UdpClient(8001);    //在本机指定的端口接收
            //加入组播，注意必须使用组播地址范围内的地址
            client.JoinMulticastGroup(IPAddress.Parse("224.0.0.1"));
            client.Ttl = 50;
            IPEndPoint remote = null;
            while (true)    //接收从远程主机发送过来的信息；
            {
                try
                {
                    byte[] bytes = client.Receive(ref remote);
                    string str = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
                    AppendString(string.Format("来自{0}：{1}", remote, str)); //订阅事件
                }
                catch
                {
                    break;   //退出循环，结束线程
                }
            }
        }

        private void Test13_5_R_Load(object sender, EventArgs e)
        {
            //将ReceiveData创建为新的线程
            Thread myThread = new Thread(new ThreadStart(ReceiveData));
            //启动该线程
            myThread.Start();
        }

        private void Test13_5_R_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Close();
        }

    }
}
