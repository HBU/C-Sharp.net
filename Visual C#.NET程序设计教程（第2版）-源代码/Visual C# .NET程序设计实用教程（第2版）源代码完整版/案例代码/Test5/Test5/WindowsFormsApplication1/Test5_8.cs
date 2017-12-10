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
    public partial class Test5_8 : Form
    {
        public Test5_8()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Test t = new Test();
            lblShow.Text= t.Fun1();
            //lblShow.Text +="\n\n"+ t.Fun2();

        }
    }
   

}
