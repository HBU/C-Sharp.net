using System;
using System.Text;
using System.Windows.Forms;

namespace test2_9
{
    public partial class Test2_9 : Form
    {
        public Test2_9()
        {
            InitializeComponent();
        }
        StringBuilder sb = new StringBuilder();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            sb.Append(txtSource.Text);
            lblShow.Text = "字符串\"" + sb.ToString() + "\"的长度为" + sb.Length;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string s = sb.ToString();
            int pos = s.IndexOf(txtSearch.Text);
            lblShow.Text += "\n目标起始索引值为" + pos;
        }
    }
}
