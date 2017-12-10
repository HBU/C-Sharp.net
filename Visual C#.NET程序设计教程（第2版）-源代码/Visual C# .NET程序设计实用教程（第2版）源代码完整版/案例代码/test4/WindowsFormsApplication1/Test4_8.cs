using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test4_1
{
    public partial class Test4_8 : Form
    {
        public Test4_8()
        {
            InitializeComponent();
        }

        private void btnTwoInt_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtOp1.Text);
            int b = Convert.ToInt32(txtOp2.Text);
            Maxer M=new Maxer();
            lblShow.Text = "最大值：" + M.Max(a, b);
        }

        private void bntDouble_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtOp1.Text);
            double b = Convert.ToDouble(txtOp2.Text);
            Maxer M = new Maxer();
            lblShow.Text = "最大值：" + M.Max(a, b);

        }

        private void bntThreeInt_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtOp1.Text);
            int b = Convert.ToInt32(txtOp2.Text);
            int c = Convert.ToInt32(txtOp3.Text);
            Maxer M = new Maxer();
            lblShow.Text = "最大值：" + M.Max(a, b,c);
        }
    }
}
