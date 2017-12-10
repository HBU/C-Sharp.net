using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Test5_3 : Form
    {
        public Test5_3()
        {
            InitializeComponent();
        }

        private void btnCreat_Click(object sender, EventArgs e)
        {
            Dog d;
            if (txtName.Text == "") d = new Dog();
            else
            {
                int age = Convert.ToInt32(txtAge.Text);
                d = new Dog(txtName.Text,age,txtType.Text);
            }
            lblShow.Text = d.GetMessage();
            lblShow.Text += "\n\n" + d.Eat();
        }
    }
}
