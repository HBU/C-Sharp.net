using System;
using System.Threading;//注意对命名空间的引用
namespace Test9_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Resource r = new Resource();
            Thread t1 = new Thread(new ThreadStart(r.Write));//创建写线程1
            Thread t2 = new Thread(new ThreadStart(r.Write));//创建写线程2
            Thread t3 = new Thread(new ThreadStart(r.Read));//创建读线程1
            Thread t4 = new Thread(new ThreadStart(r.Read));//创建读线程2
            t1.Name = "写线程1";
            t2.Name = "写线程2"; 
            t3.Name = "读线程1";
            t4.Name = "读线程2";//设置线程名
            t1.Start();
            t3.Start();
            t2.Start();
            t4.Start();//启动线程，顺序为：写读写读
           
        }       
    }
    class Resource
    {
        ReaderWriterLock rwl = new ReaderWriterLock();
        int count = 0;
        public void Read()
        {
            rwl.AcquireReaderLock(Timeout.Infinite);
            try
            {
                Console.WriteLine("+{0}进入读方法！count={1}", Thread.CurrentThread.Name, count);
                Thread.Sleep(500);
               // for (int i = 0; i <= 10000000; i++) ;
            }
            finally
            {
                rwl.ReleaseReaderLock();
                Console.WriteLine("-{0}离开读方法！", Thread.CurrentThread.Name);
            }
        }
        public void Write()
        {
            rwl.AcquireWriterLock(Timeout.Infinite);
            try
            {
                count++;
                Console.WriteLine("+{0}进入写方法！count={1}", Thread.CurrentThread.Name, count);
                Thread.Sleep(500);
               // for (int i = 0; i <= 1000000000; i++) ;
            }
            finally
            {
                rwl.ReleaseWriterLock();
                Console.WriteLine("-{0}离开写方法！", Thread.CurrentThread.Name);
            }
        }
    }
}
