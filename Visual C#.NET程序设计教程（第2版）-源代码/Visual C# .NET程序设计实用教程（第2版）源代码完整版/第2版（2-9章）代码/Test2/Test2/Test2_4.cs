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
    public partial class Test2_4 : Form
    {
        public Test2_4()
        {
            InitializeComponent();
        }

        private void Test2_4_Load(object sender, EventArgs e)
        {
            int num1 = 5, num2 = 2; 
            int a = num1 % num2;
            int b = num1 / num2;
            lblShow.Text=num1 + " % " + num2 + "= " + a;
            lblShow.Text+="\n"+num1 + " / " + num2 + " = " + b;
            a=num1++;
            b=--num2;
            lblShow.Text += "\n" + "a=num1++;后 num1 = " + num1 + "，a = " + a;
            lblShow.Text += "\n" + "b=--num2;后 num2 = " + num2 + "，b = " + b;

        }
    }
}
