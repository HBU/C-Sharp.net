using System;
using System.Threading;//注意对命名空间的引用

namespace Test9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "主线程----------";                                       //修改 当前线程 的线程名

            Thread objThread0 = new Thread(new ThreadStart(ActionMethod));           //创建线程
            objThread0.Name = "----------子线程0";                                                           //设置线程名
            objThread0.Start();                                                                                            //启动线程
            Console.WriteLine("#################");
            Thread objThread1 = new Thread(new ThreadStart(ActionMethod));           //创建线程
            objThread1.Name = "----------子线程1";                                                           //设置线程名
            objThread1.Start();                                                                                            //启动线程
            Console.WriteLine("#################");
            //Thread.Sleep(10);
            ActionMethod();
            Console.WriteLine("#################");//在主线程中调用ActionMethod()
        }

        static void ActionMethod()//线程调用的方法
        {
            for (int count = 1; count <= 50; count++)
            {
                Console.WriteLine("{0}:第{1}次", Thread.CurrentThread.Name,count);
                Thread.Sleep(100);
                
            }
        }
    }
}
