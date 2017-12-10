using System;
using System.IO;
using System.Text;
using System.Threading;
namespace Test9_8
{
    
    class Test9_8
    {
        static void Main(string[] args)
        {
            
            AsynchIOTester theApp=new AsynchIOTester("test.txt");//实例化AsynchIOTester
            AsyncCallback myCallback = new AsyncCallback(OnReadDone);//创建回调委托对象
            IAsyncResult ar = theApp.InputStream.BeginRead(
                theApp.Buffer, //存放结果的缓存
                0, //偏移值
                theApp.Buffer.Length,//缓冲大小
                myCallback, //回调方法
                (object)theApp);//局部状态对象
            Console.WriteLine("+++++主线程继续工作...");  //程序继续执行
            Thread.Sleep(1000);   //模拟主程序需要执行的时间—1秒
            Console.WriteLine("\n\n+++++主线程工作完成，执行了1秒，等待异步调用完成.... \n ");
            Console.ReadKey();
        }
       static void OnReadDone(IAsyncResult ar)//回调方法
        {

            AsynchIOTester test = (AsynchIOTester)ar.AsyncState;//获取局部状态对象
           int byteCount = test.InputStream.EndRead(ar);//获取操作结果，返回读取的字节数
           
           if (byteCount > 0)
           {
               
               string s = Encoding.GetEncoding("GB2312").GetString(test.Buffer, 0, byteCount);//转换成指对编码的字符串
               Console.Write(s);
               Thread.Sleep(100);   //模拟下一次读取间隔0.1秒，以免较快读完
               AsyncCallback myCallback = new AsyncCallback(OnReadDone);//创建回调委托对象
               test.InputStream.BeginRead(test.Buffer, 0, test.Buffer.Length, myCallback, (object)test);//如果没有读完，再次异步调用BeginRead
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
            {return buffer;}
        }
        public Stream InputStream
        {
            get{return inputStream;}
        }
       
    }
}
