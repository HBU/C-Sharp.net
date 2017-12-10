using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test2_5
{
    public partial class Test2_5 : Form
    {
        public Test2_5()
        {
            InitializeComponent();
        }

        private void Test2_5_Load(object sender, EventArgs e)
        {
            int a, b = 5;
            char c = '啊';
            a = c;                    //字符型转整型
            float x = 42;
            x /= b;                     //整型转浮点型
            lblShow.Text = "整型变量a的值为" + a;    //整型转为字符串
            lblShow.Text += "\n浮点型变量x的值为" + x; //浮点型转为字符串

        }
    }
}
