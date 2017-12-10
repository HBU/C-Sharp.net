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
    public partial class Test3_1 : Form
    {
        public Test3_1()
        {
            InitializeComponent();
        }

    private void btnOk_Click(object sender, EventArgs e)
    {
        int year = int.Parse(txtYear.Text);
        if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
        {
            lblShow.Text = year + "年是闰年！";
        }
        else
        {
            lblShow.Text = year + "年不是闰年！";
        }
    }

        

    }
}
