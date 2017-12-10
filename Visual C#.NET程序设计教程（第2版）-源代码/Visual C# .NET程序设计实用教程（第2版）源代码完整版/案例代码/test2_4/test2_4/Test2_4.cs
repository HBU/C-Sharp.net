using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test2_4
{
    public partial class Test2_4 : Form
    {
        public Test2_4()
        {
            InitializeComponent();
        }

        private void Test2_4_Load(object sender, EventArgs e)
        {
            int i = 1, j = 1, p, q;
            p = (i++) + (i++) + (i++);
            q = (++j) + (++j) + (++j);
            lblShow.Text = "变量i的值为" + i;
            lblShow.Text += "\n变量j的值为" + j;
            lblShow.Text += "\n变量p的值为" + p;
            lblShow.Text += "\n变量q的值为" + q;
        }
    }
}
