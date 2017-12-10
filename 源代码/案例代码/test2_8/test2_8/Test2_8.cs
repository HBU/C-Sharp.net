using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test2_8
{
    public partial class Test2_8 : Form
    {
        public Test2_8()
        {
            InitializeComponent();
        }

        private void Test2_8_Load(object sender, EventArgs e)
        {
            int[,] a = new int[2, 3] { {1, 2, 3},{ 4, 5,5} };
            int[][] b = new int[2][];
            b[0] = new int[3] { 1, 2, 3 };
            b[1] = new int[4] { 4, 5, 6,7 };
            lblShow.Text = "a是二组数组，共6个数组元素，均为整数值。";
            lblShow.Text += "\nb是一维数组，共2个数组元素，均为子数组。\n";
            lblShow.Text += "a[0,0]的值为" + a[0, 0];
            lblShow.Text += "\nb[0][0]的值为" + b[0][0];
        }
    }
}
