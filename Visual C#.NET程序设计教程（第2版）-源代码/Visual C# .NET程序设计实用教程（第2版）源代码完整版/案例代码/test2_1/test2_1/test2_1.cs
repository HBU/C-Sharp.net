using System;
using System.Windows.Forms;

namespace test2_1
{
    public partial class test2_1 : Form
    {
        public test2_1()
        {
            InitializeComponent();
        }

        private void test2_1_Load(object sender, EventArgs e)
        {
            int a = 12, b = 15, c, d;
            c = a + b;
            d = c * b;
            lblShow.Text = "变量c的值{" + c;
            lblShow.Text +="\n变量d的值为" + d;
            lblShow.Text += Convert.ToDateTime("2011-10-1");
        }
    }
}
