using System;
using System.Threading;//注意对命名空间的引用
namespace Test9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "主线程";//修改当前线程的线程名
            Thread objThread = new Thread(new ThreadStart(ActionMethod));//创建线程
            objThread.Name = "子线程";//设置线程名
            objThread.Start();//启运线程
            ActionMethod();//在主线程中调用ActionMethod()
        }
        static void ActionMethod()//线程调用的方法
        {
            for (int count = 1; count <= 5; count++)
            {
                Console.WriteLine("{0}:第{1}次", Thread.CurrentThread.Name,count);
                

            }
        }
    }
}
