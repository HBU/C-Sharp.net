using System;
using System.Threading;//注意对命名空间的引用
using System.Runtime.Remoting.Contexts;
namespace Test9_3
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
   [Synchronization]
    class CountClass:ContextBoundObject
    {
        public int count = 42;
        public void ReadTask()//读取count的值
        {
            for (int i = 1; i <5; i++)
            {
                Console.WriteLine("{0}:Count={1}", Thread.CurrentThread.Name, count);
                
            }
        }
        public void WriteTask()//修改count的值
        {
            for (int i = 1; i < 5; i++)
            {
                count++;
                Console.WriteLine("{0}:Count={1}", Thread.CurrentThread.Name, count);
         
            }

        }
    }
}
