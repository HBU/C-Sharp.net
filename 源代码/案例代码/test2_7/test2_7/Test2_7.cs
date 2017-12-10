using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test2_7
{
    public partial class Test2_7 : Form
    {
        public Test2_7()
        {
            InitializeComponent();
        }

        private void Test2_7_Load(object sender, EventArgs e)
        {
            int[] a = { 5, 1, 2, 4, 3 };
            int[] b = new int[5];
            Array.Copy(a, b, 5);
            Array.Clear(a, 0, 5);
            lblShow.Text = b[0] + "  " + b[1] + "  " + b[2] + "  " + b[3] + "  " + b[4] + "\n";
            Array.Sort(b);
            lblShow.Text += b[0] + "  " + b[1] + "  " + b[2] + "  " + b[3] + "  " + b[4] + "\n";
            Array.Reverse(b);
            lblShow.Text += b[0] + "  " + b[1] + "  " + b[2] + "  " + b[3] + "  " + b[4];
        }
    }
}
