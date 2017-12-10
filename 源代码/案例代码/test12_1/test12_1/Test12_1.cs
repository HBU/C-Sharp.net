using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace test11_1
{
    public partial class Test12_1 : Form
    {
        public Test12_1()
        {
            InitializeComponent();
        }

        private void Test11_1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"d:\Data\日志.txt", true);
            sw.WriteLine(DateTime.Now.ToString());
            sw.WriteLine(txtSource.Text);
            sw.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"d:\Data\日志.txt");
            txtShow.Text = sr.ReadToEnd(); ;
            sr.Close();
        }
    }
}
