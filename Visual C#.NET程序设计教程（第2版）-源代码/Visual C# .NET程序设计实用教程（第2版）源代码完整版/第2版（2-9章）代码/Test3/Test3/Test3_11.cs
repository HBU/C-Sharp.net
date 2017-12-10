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
    public partial class Test3_11 : Form
    {
        public Test3_11()
        {
            InitializeComponent();
        }

    private void btnFilter_Click(object sender, EventArgs e)
    {
        char ch_old, ch_new;
        ch_old = txtSource.Text[0];
        lblShow.Text = "过滤连续的重复字符后："+ch_old;
        for (int i = 1; i < txtSource.Text.Length; i++)
        {
            ch_new = (char)txtSource.Text[i];
            if (ch_new == ch_old) continue;
            lblShow.Text += ch_new.ToString();
            ch_old = ch_new;
        }

    }

       
    }
}
