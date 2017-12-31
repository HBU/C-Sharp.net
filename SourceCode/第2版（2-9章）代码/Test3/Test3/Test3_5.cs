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
    public partial class Test3_5 : Form
    {
        public Test3_5()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtNum.Text);
            int i = 1;//为循环变量赋初值
            int sum = 0;
            while (i <= n)//循环条件
            {//循环体
                sum += i;
                i++;//改变循环变量的值
            }
            lblShow.Text = "1+2+…+" + n + "=" + sum;
        }
    }

   
}
