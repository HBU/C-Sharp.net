using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test3_10
{
public partial class Test3_10 : Form
{
    public Test3_10()
    {
        InitializeComponent();
    }

    private void btnFilter_Click(object sender, EventArgs e)
    {
        char ch_old, ch_new;
        ch_old = ' ';
        lblShow.Text = "过滤之后的结果如下：\n";
        for(int i =1; i<txtSource.Text.Length ;i++)
        {
            ch_new = (char)txtSource.Text[i];
            if (ch_new == ch_old)  continue;
            lblShow.Text += ch_new.ToString();
            ch_old = ch_new;
        } 
    }
}
}
