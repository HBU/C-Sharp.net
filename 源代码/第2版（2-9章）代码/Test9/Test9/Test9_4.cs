using System;
using System.Threading;//注意对命名空间的引用
using System.Runtime.Remoting.Contexts;
namespace Test9_4
{
    class Program
    {
        static void Main(string[] args)
        {

            CountClass c = new CountClass();
            Thread readThread = new Thread(new ThreadStart(c.ReadTask));//创建线程
            readThread.Name = "读线程";//设置线程名
            Thread writeThread = new Thread(new ThreadStart(c.WriteTask));//创建线程
            writeThread.Name = "写线程";//设置线程名
            readThread.Start();
            writeThread.Start();

        }

    }
    class CountClass 
    {
        public int count = 42;
        public void ReadTask()//读取count的值
        {
            //Monitor.Enter(this);
            lock (this)
            {
                Console.WriteLine("进入代码同步区域");
                for (int i = 1; i < 5; i++)
                {
                    Console.WriteLine("{0}:Count={1}", Thread.CurrentThread.Name, count);

                }
                Console.WriteLine("退出代码同步区域");
            }
     
            //Monitor.Exit(this);
        }
        public void WriteTask()//修改count的值
        {
            //Monitor.Enter(this);
            lock (this)
            {
                Console.WriteLine("进入代码同步区域");
                for (int i = 1; i < 5; i++)
                {
                    count++;
                    Console.WriteLine("{0}:Count={1}", Thread.CurrentThread.Name, count);
                }
                Console.WriteLine("退出代码同步区域");
                //Monitor.Exit(this);
            }

        }
    }
}
