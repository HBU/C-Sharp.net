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
    public partial class Test3_4 : Form
    {
        public Test3_4()
        {
            InitializeComponent();
        }

    private void btnOk_Click(object sender, EventArgs e)
    {
        double money = Convert.ToDouble(txtMoney.Text);
        int month = Convert.ToInt32(txtMonth.Text);
        int seat=Convert.ToInt32(txtSeat.Text);
        if (month >= 5 && month <= 10)
        {
            if (seat == 1) money *= 0.75;
            else money *= 0.9;
        }
        else
        {
            switch (seat)
            {
                case 1:
                    money *= 0.3;break;
                case 2:
                    money *= 0.6;break;
            }
        }
        lblShow.Text = "打折后的机票价格是：" + money;
    }

       
    }
}
