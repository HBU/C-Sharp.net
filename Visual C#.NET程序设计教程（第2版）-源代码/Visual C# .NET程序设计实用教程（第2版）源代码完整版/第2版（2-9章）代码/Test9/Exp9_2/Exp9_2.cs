using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Threading;

namespace Exp9_2
{
    public partial class Exp9_2 : Form
    {
        public Exp9_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AsynchIOTester theApp = new AsynchIOTester("test.txt");//实例化AsynchIOTester
            AsyncCallback myCallback = new AsyncCallback(OnReadDone);//创建回调委托对象
            IAsyncResult ar = theApp.InputStream.BeginRead(
                theApp.Buffer, //存放结果的缓存
                0, //偏移值
                theApp.Buffer.Length,//缓冲大小
                myCallback, //回调方法
                (object)theApp);//局部状态对象
            label2.Text = "正在读取....";

        }
        private  void OnReadDone(IAsyncResult ar)//回调方法
        {

            AsynchIOTester test = (AsynchIOTester)ar.AsyncState;//获取局部状态对象
            int byteCount = test.InputStream.EndRead(ar);//获取操作结果，返回读取的字节数

            if (byteCount > 0)
            {

                string s = Encoding.GetEncoding("GB2312").GetString(test.Buffer, 0, byteCount);//转换成指对编码的字符串
                label1.Text += s;
                Thread.Sleep(100);
                AsyncCallback myCallback = new AsyncCallback(OnReadDone);//创建回调委托对象
                test.InputStream.BeginRead(test.Buffer, 0, test.Buffer.Length, myCallback, (object)test);//如果没有读完，再次异步调用BeginRead
            }
            else
            {
                label2.Text = "读取完成!";
            }
        }
    }
    class AsynchIOTester//定义状态对象
    {
        private Stream inputStream;//输入流
        private byte[] buffer;//存入读入数据的缓冲区
        private string filename;
        public AsynchIOTester(string filename)
        {
            this.filename = filename;
            inputStream = File.OpenRead(filename);//打开输入流
            buffer = new byte[16];//分配缓冲
        }
        public byte[] Buffer
        {
            get
            { return buffer; }
        }
        public Stream InputStream
        {
            get { return inputStream; }
        }

    }
}
