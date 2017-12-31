using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Test4_0
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Exp4_3.Exp4_3());
        }
    }
}
