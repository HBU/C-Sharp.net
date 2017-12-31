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
    public partial class Test2_9 : Form
    {
        public Test2_9()
        {
            InitializeComponent();
        }
        StringBuilder sb = new StringBuilder(); //用于保存用户输入
        private void btnInsert_Click(object sender, EventArgs e)
        {
            sb.Append(txtSource.Text);
            int pos=Convert.ToInt32(txtPos.Text);
            sb.Insert(pos, txtInsert.Text, 1);
            txtSource.Text = sb.ToString();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string str = sb.ToString();
            int loc=str.IndexOf(txtSelect.Text);
            lblShow.Text = "\n查找的字符串在主串中的起始索引值为" + loc;
        }
    }
}
