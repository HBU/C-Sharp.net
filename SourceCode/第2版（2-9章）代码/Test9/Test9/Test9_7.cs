using System;
using System.Threading;

namespace Test9_7
{
    public delegate string AsyncDelegate(int callTime); //定义一个委托，用来提供异步调用的接口

    class Test9_7
    {
        static void Main(string[] args)
        {
            AsyncDemo asyncDemo = new AsyncDemo();
            AsyncDelegate asyncDelegate = new AsyncDelegate(asyncDemo.TestMethod); //封装要异步调用的方法

            Console.WriteLine(DateTime.Now.ToString() + "  ### 主线程开始工作");
            Thread.Sleep(3000);//三秒输出一行，便于观察

            //开始异步调用（指定该方法的执行时间—10秒），并指定回调方法
            IAsyncResult iAsyncResult = asyncDelegate.BeginInvoke(10000, new AsyncCallback(CallbackMethod), asyncDelegate);
            Thread.Sleep(3000);//三秒输出一行，便于观察

            Console.WriteLine(DateTime.Now.ToString() + "  ### 主线程继续工作");  //程序继续执行
            Thread.Sleep(5000);   //模拟主程序需要执行的时间—5秒----注意：与异步执行的程序同时执行，节约了时间
            Console.WriteLine(DateTime.Now.ToString() + "  ### 主线程工作完成：执行了3秒，等待异步调用完成----");
            Console.ReadKey();
        }

        static void CallbackMethod(IAsyncResult iAsyncResult)  //异步调用结束后的回调方法
        {           
            AsyncDelegate asyncDelegate = (AsyncDelegate)iAsyncResult.AsyncState;  //从异步操作的状态中提取AsyncDelegate委托
            string result = asyncDelegate.EndInvoke(iAsyncResult);//获取异步调用的结果
            Console.WriteLine(DateTime.Now.ToString() + "  @@@ 异步调用完成：{0}!", result);
        }
    }

    class AsyncDemo
    {
        public string TestMethod(int callTime)   //异步调用的方法
        {
            Console.WriteLine(DateTime.Now.ToString() + "  @@@ 异步调用的方法开始...");
            Thread.Sleep(callTime);    //模拟该方法需要执行的时间—3秒
            return " @@@ 方法完成需要的时间是" + callTime / 1000 + "秒";
        }
    }
}
