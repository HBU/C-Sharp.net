using System;
using System.Threading;

namespace Test9_6
{


    public class Test9_6
    {
        public static void Main()
        {
            //将任务加入线程池的任务队列 
            ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadProc));
            Console.WriteLine("Main thread does some work, then sleeps.");
            //主线程等待 
            Thread.Sleep(1000);
            Console.WriteLine("Main thread exits.");
        }
        //线程函数
        static void ThreadProc(Object stateInfo)
        {
            //线程函数向控制台输出
            Console.WriteLine("Hello from the thread pool.");
        }
    }
}
