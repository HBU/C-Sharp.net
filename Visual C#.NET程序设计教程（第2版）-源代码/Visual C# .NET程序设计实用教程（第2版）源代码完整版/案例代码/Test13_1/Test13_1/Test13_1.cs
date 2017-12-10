using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace Test13_1
{
    public partial class Test13_1 : Form
    {
        public Test13_1()
        {
            InitializeComponent();
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            lstResult.Items.Clear();
            string name = Dns.GetHostName();    //获到本地主机名
            lstResult.Items.Add("本机主机名：" + name);
            IPHostEntry my = Dns.GetHostEntry(name);//获取本地的IP地址信息
            lstResult.Items.Add("本机所有IP地址：");
            foreach (IPAddress ip in my.AddressList) //输出本地IP地址信息
            {
                lstResult.Items.Add(ip);
            }
 
        }

        private void btnEndPoint_Click(object sender, EventArgs e)
        {
            lstResult.Items.Clear();
            IPAddress ip = IPAddress.Parse("127.0.0.1");//把字符串解析为IP地址
            IPEndPoint p = new IPEndPoint(ip, 80); //创建通信端点
            lstResult.Items.Add("TCP端点是 " + p.ToString());
            lstResult.Items.Add("该端点的IP地址是" + p.Address);
            lstResult.Items.Add("该端点的IP地址族是" + p.AddressFamily);
            lstResult.Items.Add("TCP最大端口号是" + IPEndPoint.MaxPort);
            lstResult.Items.Add("TCP最小端口号是" + IPEndPoint.MinPort);
        }

        private void btnRemote_Click(object sender, EventArgs e)
        {
            lstResult.Items.Clear();
            //将主机名或IP地解析为IPHostEntry的实例
            IPHostEntry host = Dns.GetHostEntry(txtRemote.Text);
            IPAddress[] rip = host.AddressList;//获取与关机相关联的IP地址列表
            lstResult.Items.Add(host.HostName);//获取主机的DNS名
            lstResult.Items.AddRange(rip);
        }
    }
}
