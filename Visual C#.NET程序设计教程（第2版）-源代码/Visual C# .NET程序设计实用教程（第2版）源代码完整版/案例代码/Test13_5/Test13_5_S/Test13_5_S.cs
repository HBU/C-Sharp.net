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
namespace Test13_5
{
    public partial class Test13_5_S : Form
    {
        public Test13_5_S()
        {
            InitializeComponent();
         }

private void btnSend_Click(object sender, EventArgs e)
{
    UdpClient client = new UdpClient(); //系统将自动分配最合适的本地 IPv4 地址和端口号
    client.EnableBroadcast = true;    //允许发送广播
    IPEndPoint p = new IPEndPoint(IPAddress.Parse("224.0.0.1"), 8001);//必须使用组播地址
    byte[] bytes = Encoding.UTF8.GetBytes(txtSend.Text); //将发送内容转换为字节数组
    try
    {
        client.Send(bytes, bytes.Length, p);        //向子网发送信息
        txtSend.Clear();
        txtSend.Focus();
    }
    catch (Exception err)
    {
        MessageBox.Show(err.Message, "发送失败");
    }
    finally
    {
        client.Close();
    }
} 
    }
}
