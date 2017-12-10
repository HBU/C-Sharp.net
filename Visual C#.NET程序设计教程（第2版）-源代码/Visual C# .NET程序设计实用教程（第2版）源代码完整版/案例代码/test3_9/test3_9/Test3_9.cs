using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test3_9
{
public partial class Test3_9 : Form
{
    public Test3_9()
    {
        InitializeComponent();
    }

    string[] x = new string[100];
    int n = 0;

    private void btnAdd_Click(object sender, EventArgs e)
    {
        if (n < 100)
            x[n] = txtName.Text;
        n++;
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        int k = -1;
        for (int i = 1; i < x.Length; i++)
        {
            if (x[i] == txtSearch.Text)
            {
                k = i;
            }
            else if (String.IsNullOrEmpty(x[i]))
            {
                lblShow.Text = "检索失败，终止循环！";
                break;
            }
        }
        if(k!=-1)
            lblShow.Text = "检索成功，索引号为：" + k;
    }
}
}
