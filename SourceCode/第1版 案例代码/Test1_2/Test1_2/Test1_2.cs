using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test1_2
{
    public partial class Test1_2 : Form
    {
        public Test1_2()
        {
            InitializeComponent();
        }

        private void Test1_2_Load(object sender, EventArgs e)
        {
            //设置本窗体的标题文字
            this.Text = "我的第一个Windows程序";

            //先创建标签控件，再设置其显示文本和位置等属性
            Label lblShow = new Label();
            lblShow.Location = new Point(50, 30);
            lblShow.AutoSize = true;
            lblShow.Text = "本程序由罗福强设计，欢迎您使用！";

            //将标签控件添加到本窗体之中
            this.Controls.Add(lblShow);
        }
    }
}
