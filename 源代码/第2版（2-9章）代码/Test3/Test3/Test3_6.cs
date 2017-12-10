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
    public partial class Test3_6 : Form
    {
        public Test3_6()
        {
            InitializeComponent();
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtNum.Text);
            int i = 1;//为循环变量赋初值
            int sum = 1;
            do
            {//循环体
                sum *= i;
                i++;//改变循环变量的值
            }while (i <= n);//循环条件
            lblShow.Text = "1*2*…*" + n + "=" + sum;
        }
    }
}
