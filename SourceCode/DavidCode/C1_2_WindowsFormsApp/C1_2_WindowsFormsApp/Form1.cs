using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C1_2_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //设置本窗体的标题文字
            this.Text = "我的第一个Windows程序";

            //先创建标签控件，再设置其显示文本和位置等属性
            Label lblShow = new Label
            {
                Location = new Point(50, 30),                               //位置
                AutoSize = true,                                                    //大小
                Text = "本程序由David设计，欢迎您使用！"      //文本
            };

            //将标签控件添加到本窗体之中
            this.Controls.Add(lblShow);
        }
    }
}
