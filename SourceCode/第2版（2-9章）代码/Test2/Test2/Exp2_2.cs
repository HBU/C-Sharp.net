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
    public partial class Exp2_2 : Form
    {
        public Exp2_2()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
        int money=Convert.ToInt32(txtMoney.Text);
        int year = Convert.ToInt32(txtYear.Text);
        double rate = Convert.ToDouble(txtRate.Text)/100;
        double interest=money*rate*year;
        txtInterest.Text = interest.ToString();
        double total = money + interest;
        txtTotal.Text = total.ToString();
        }
    }
}
