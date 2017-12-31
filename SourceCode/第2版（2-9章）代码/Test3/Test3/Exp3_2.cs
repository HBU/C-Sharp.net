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
    public partial class Exp3_2 : Form
    {
        public Exp3_2()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtOriginal.Text);
            int turnNum=0;
            while (num > 0)
            {
                turnNum =turnNum*10+num % 10;
                num=num/10;
            }
            txtTurn.Text = turnNum.ToString();
        }
    }
}
