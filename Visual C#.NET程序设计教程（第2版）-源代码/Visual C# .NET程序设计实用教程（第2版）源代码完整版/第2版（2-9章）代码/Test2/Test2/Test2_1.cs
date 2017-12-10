using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test2
{
    public partial class Test2_1 : Form
    {
        public Test2_1()
        {
            InitializeComponent();
        }

        private void Test2_1_Load(object sender, EventArgs e)
        {
            int a = 15, b, c, sum;//定义变量并初始化
            b = c = 20;//对变量b和c同时赋初值
            sum = a + b + c;//引用变量a、b、c的值，相加之后赋值给变量sum
            lblShow.Text = "变量a、b、c之和为：" + sum;//引用变量sum的值
        }
    }
}
