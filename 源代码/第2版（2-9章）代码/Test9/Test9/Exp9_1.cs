using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace Exp9_1
{
    class Exp9_1
    {
    static void Main(string[] args)
    {
        Thread timeThread = new Thread(new ThreadStart(GetTime));//创建线程

        timeThread.Start();//启运线程
            
    }
    static void GetTime()
    {
        while (true)
        {
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine(System.DateTime.Now.ToString());
        }
    }
    }
}
