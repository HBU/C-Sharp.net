using System;
using System.Threading;

namespace Test9_2
{
    class Test9_2
    {
        public static Thread sleeper;
        public static Thread awaker;
        public void SleepThread()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.Write(i + ",");
                if (i == 4 || i == 8)
                {
                    Console.WriteLine("Thread is sleep at " + i);
                    try
                    {
                        Thread.Sleep(20);  //暂停线程
                    }
                    catch (ThreadInterruptedException e) //捕获中断异常
                    {
                        Console.WriteLine("Thread is interrupted");
                    }
                }
            }
        }

        public void AwakeThread()
        {
            for (char ch = 'A'; ch < 'K'; ch++)
            {
                Console.Write(ch + ",");
                if (sleeper.ThreadState == System.Threading.ThreadState.WaitSleepJoin)
                {
                    Console.WriteLine("Thread is awake at " + ch);
                    sleeper.Interrupt();    						//中断线程     
                }
            }
        }
        static void Main(string[] args)
        {
            Test9_2 mi = new Test9_2();
            sleeper = new Thread(new ThreadStart(mi.SleepThread));	//创建第1个线程
            awaker = new Thread(new ThreadStart(mi.AwakeThread));	//创建第2个线程
            sleeper.Start();  									//启动第1个线程
            awaker.Start();  									//启动第2个线程
           
        }


    }
}
