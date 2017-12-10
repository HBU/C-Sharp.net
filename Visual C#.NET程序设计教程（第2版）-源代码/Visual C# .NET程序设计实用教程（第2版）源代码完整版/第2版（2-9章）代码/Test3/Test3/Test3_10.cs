using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test3
{
    public partial class Test3_10 : Form
    {
        public Test3_10()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtNum.Text);
            int flag = 1;
            for (int i = 2; i <= Math.Sqrt(n); i++)//Math.Sqrt(n):求n的平方根
            {
                if (n % i == 0)
                {
                    flag = 0;//通过flag的值确定,确定是否执行了if语句
                    break;//当n能被某个数整除是，n一定不是质数，循环中断。
                }
            }
            if (flag == 1) lblShow.Text = n + "是一个质数";
            else lblShow.Text = n + "不是一个质数";
        }

       
    }
}
