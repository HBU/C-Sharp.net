using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test8_4
{
    public partial class Test8_4 : Form
    {
        public Test8_4()
        {
            InitializeComponent();
        }

        private void txtSource_TextChanged(object sender, EventArgs e)
        {
            lblTarget.Text = "正在输入：\n" + txtSource.Text;
        }

        private void txtSource_Enter(object sender, EventArgs e)
        {
            txtSource.Text = "";
        }

        private void txtSource_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("字符串复制成功","恭喜",MessageBoxButtons.OK);
        }
    }
}
