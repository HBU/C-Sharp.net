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
    public partial class Exp_1 : Form
    {
        public Exp_1()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
    double c = Convert.ToInt32(txtCelsius.Text);
    double f = 9.0 / 5 * c + 32;
    txtFahrenheit.Text = f.ToString();
        }
    }
}
