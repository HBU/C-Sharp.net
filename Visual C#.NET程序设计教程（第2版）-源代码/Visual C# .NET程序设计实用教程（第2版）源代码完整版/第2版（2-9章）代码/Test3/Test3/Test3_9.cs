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
    public partial class Test3_9 : Form
    {
        public Test3_9()
        {
            InitializeComponent();
        }

    private void button1_Click(object sender, EventArgs e)
    {
        int n = Convert.ToInt32(txtNum.Text);
        StringBuilder sb = new StringBuilder();
        int i,j;
        for (i = 1; i <= n; i++)
        {
            for (j = 1; j <= n - i; j++)
            {
                sb.Append(" ");
            }
            for (j = 1; j <= 2 * i - 1; j++)
            {
                sb.Append("*");
            }
            sb.Append("\n");
        }
        lblShow.Text = sb.ToString();
    }
    }
}
