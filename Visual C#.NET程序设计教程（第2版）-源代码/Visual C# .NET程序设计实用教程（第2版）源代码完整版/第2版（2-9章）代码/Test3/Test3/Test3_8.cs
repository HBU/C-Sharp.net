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
    public partial class Test3_8 : Form
    {
        public Test3_8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = txtString.Text;
            int count=0;
            foreach (char ch in str)
            {
                if (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z')
                    count++;
            }
            lblShow.Text = string.Format("字符串中包括{0}个英文字母！", count);
        }
    }
}
