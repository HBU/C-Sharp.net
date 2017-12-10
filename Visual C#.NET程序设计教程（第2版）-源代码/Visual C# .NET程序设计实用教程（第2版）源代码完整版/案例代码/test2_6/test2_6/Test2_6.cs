using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test2_6
{
    public partial class Test2_6 : Form
    {
        public Test2_6()
        {
            InitializeComponent();
        }

        private void Test2_6_Load(object sender, EventArgs e)
        {
            int i = 25, j = 12;
            bool k;
            k = (i != j);
            string result = " i!=j的值为" + k;
            k = (i != j && i >= j + 20);
            result += "\n i!=j && i>=j+20的值为" + k;
            lblShow.Text = result;
        }
    }
}
