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
    public partial class Test2_6 : Form
    {
        public Test2_6()
        {
            InitializeComponent();
        }

        private void Test2_6_Load(object sender, EventArgs e)
        {
            int a = 8, b = 5;
            bool k;
            k = a != b;
            lblShow.Text = "a!=b;的结果是:" + k;
            k = a>=0&&a<=10;
            lblShow.Text += "\na>=0&&&&a<=10;的结果是:" + k;
            k = a <= b && ++a == 9;
            lblShow.Text += "\na <= b &&&& ++a == 9;的结果是:" + k + ",a在执行后的结果是：" + a;
            k = a <= b & ++a == 9;
            lblShow.Text += "\na <= b && ++a == 9;的结果是:" + k + ",a在执行后的结果是：" + a;


        }
    }
}
