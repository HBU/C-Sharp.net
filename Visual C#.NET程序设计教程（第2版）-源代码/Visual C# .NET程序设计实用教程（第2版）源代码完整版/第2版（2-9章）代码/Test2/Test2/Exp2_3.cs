using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test2
{
    public partial class Exp2_3 : Form
    {
        public Exp2_3()
        {
            InitializeComponent();
        }
        double[] a = new double[5];//用于保存用户输入
        int i = 0;//记录当前添加的数字的索引
       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double element = double.Parse(txtElement.Text);
            a[i] = element;
            txtPrior.Text += a[i] + " ";
            i++;
            txtElement.Text="";
            
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Array.Sort(a);
            txtSort.Text = a[0] + " " + a[1] + " " + a[2] + " " + a[3] + " " + a[4];
        }
    }
}
