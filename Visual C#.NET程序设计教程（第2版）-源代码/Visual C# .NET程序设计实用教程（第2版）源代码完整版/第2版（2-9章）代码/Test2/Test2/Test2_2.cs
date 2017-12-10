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
    public partial class Test2_2 : Form
    {
        public Test2_2()
        {
            InitializeComponent();
        }
        enum Season { Spring = 10, Summer, Autumn = 20, Winter };//声明枚举型

        private void Test2_2_Load(object sender, EventArgs e)
        {
            Season currentSeason, nextSeason;//定义枚举变量currentSeason和nextSeason
            currentSeason = Season.Summer;//使用枚举值Summer初始化currentSeason
            nextSeason = (Season)21;//将整数转换为枚举值，初始化nextSeason
            lblShow.Text = "枚举变量currentSeason的值为：" + (int)currentSeason;//将枚举型变量的值转换为整数值
            lblShow.Text += "\n枚举变量nextSeason代表枚举元素：" + nextSeason;//使用枚举型变量的值

        }
    }
}
