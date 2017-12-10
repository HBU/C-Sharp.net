using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test7_1
{
public partial class Test7_1 : Form
{
    public Test7_1()
    {
        InitializeComponent();
    }

    private void Test7_1_Load(object sender, EventArgs e)
    {
        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = a[i] + a[i + 3];
        }
        foreach (int x in a)
        {
            lblShow.Text = x + " ";
        }
    }
}
}
