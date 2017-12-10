using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exp7_1
{
    public partial class Exp7_1 : Form
    {
        public Exp7_1()
        {
            InitializeComponent();
        }

    private void btnSort_Click(object sender, EventArgs e)
    {
        string[] sources= txtSource.Text.Split(',');
        int[] a = new int[sources.Length];
    try
    {
        for (int i = 0; i < sources.Length; i++)
        {
            a[i] = Convert.ToInt32(sources[i]);
        }
    }
    catch (Exception ex)
    {
        lblShow.Text = ex.Message;
    }

        for (int i = 1; i <= a.Length; i++)
        {
            for (int j = 1; j <= a.Length - i; j++)
            {
                if (a[j - 1] > a[j])
                {
                    int t = a[j - 1];
                    a[j - 1] = a[j];
                    a[j] = t;
                }
            }
        }
        foreach (int t in a)
        {
            lblShow.Text += String.Format("{0,-4:D}", t);
        }

    }
}
}
