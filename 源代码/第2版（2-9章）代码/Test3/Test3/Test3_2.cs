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
    public partial class Test3_2 : Form
    {
        public Test3_2()
        {
            InitializeComponent();
        }

    private void btnOk_Click(object sender, EventArgs e)
    {
        double h, w, t;
        h = Convert.ToDouble(txtHeight.Text);
        w = Convert.ToDouble(txtWeight.Text);
        t = w / (h * h);
        if (t < 18)
            lblShow.Text = "您的身材偏瘦！";
        else if (t >= 18 && t < 25)
            lblShow.Text = "您的身材全完标准！";
        else if(t>=25&&t<27)
            lblShow.Text = "您的身材偏胖！";
        else
            lblShow.Text = "您的身材有点肥胖！";
    }
    }
}
