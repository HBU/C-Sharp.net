using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test2_2
{
    public partial class test2_2 : Form
    {
        public test2_2()
        {
            InitializeComponent();
        }
        enum MyEnum { a = 101, b, c, d = 201, e, f };  //声明枚举型
        private void test2_2_Load(object sender, EventArgs e)
        {
            MyEnum x = MyEnum.f;                 //使用枚举型（包括定义变量和引用枚举值）
            MyEnum y = (MyEnum)202;              //将整数转换为枚举值
            string result = "枚举数x的值为"+ (int)x; //将枚举型变量的值转换为整数值
            result += "\n枚举数y代表枚举元素" + y;
            lblShow.Text = result;
        }
    }
}
