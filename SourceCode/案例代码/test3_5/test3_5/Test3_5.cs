using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test3_5
{
public partial class Test3_5 : Form
{
    public Test3_5()
    {
        InitializeComponent();
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
        int n = 0, i=0;
        do
        {
            char c = txtSource.Text[i++];
            if (c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z')
            {
                n++;
            }
        } while (i!= txtSource.Text.Length);
        lblShow.Text = String.Format("在该字符中，英文字母共：{0}个。",n);
    }
}
}
