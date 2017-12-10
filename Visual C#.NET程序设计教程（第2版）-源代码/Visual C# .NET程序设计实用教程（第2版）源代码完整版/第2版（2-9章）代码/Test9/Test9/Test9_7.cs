using System;
using System.Threading;
namespace Test9_7
{
    public delegate string AsyncDelegate(int callTime); //定义一个委托，用来提供异步调用的接口
    class Test9_7
    {
        static void Main(string[] args)
        {
            AsyncDemo ad = new AsyncDemo();
            AsyncDelegate dlgt = new AsyncDelegate(ad.TestMethod); //封装要异步调用的方法
           //开始异步调用（指定该方法的执行时间—3秒），并指定回调方法
            IAsyncResult ar = dlgt.BeginInvoke(3000, new AsyncCallback(CallbackMethod), dlgt); 
            Console.WriteLine("主线程继续工作...");  //程序继续执行
            Thread.Sleep(1000);   //模拟主程序需要执行的时间—1秒
            Console.WriteLine("主线程工作完成，执行了1秒，等待异步调用完成....");
            Console.ReadKey();
        }
        static void CallbackMethod(IAsyncResult ar)  //异步调用结束后的回调方法
        {
            //从异步操作的状态中提取AsyncDelegate委托
            AsyncDelegate dlgt = (AsyncDelegate)ar.AsyncState; 
            string result = dlgt.EndInvoke(ar);//获取异步调用的结果
            Console.WriteLine("异步调用完成,{0}!",result);
        }
    }
    class AsyncDemo
    {
        public string TestMethod(int callTime)   //异步调用的方法
        {
            Console.WriteLine("异步调用的方法开始...");
            Thread.Sleep(callTime);    //模拟该方法需要执行的时间—3秒
            return "方法完成需要的时间是" + callTime / 1000 + "秒";
        }
    }
}
