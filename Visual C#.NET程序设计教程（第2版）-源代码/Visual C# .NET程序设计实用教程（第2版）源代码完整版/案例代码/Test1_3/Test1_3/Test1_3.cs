using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Test1_3
{
    public partial class Test1_3 : Form
    {
        public Test1_3()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //定义字符串变量
            string strResult;
            //提取在文本框中录入的文字
            strResult = txtName.Text + "，你好！欢迎使用本程序！";
            //显示结果
            lblShow.Text = strResult;
        }
    }
}
