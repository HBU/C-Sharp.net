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
    public partial class Test2_7 : Form
    {
        public Test2_7()
        {
            InitializeComponent();
        }

        private void Test2_7_Load(object sender, EventArgs e)
        {
        int[] a = { 23, 15, 27, 12, 24 };   //创建数组a并初始化 
        int[] b = new int[5];      //创建数组b
        Array.Copy(a, b, 5);      //把数组a所有数组元素复制给数组b
        b[3] = 18;                //把数组b中的第4个元素的值该为18
        Array.Clear(a, 0, 5);      //清除数组a各数组元素的值
        lblShow.Text = "数组b的原始值："+b[0] + "  " + b[1] + "  " + b[2] + "  " + b[3] + "  " + b[4] + "\n";
        Array.Sort(b);           //对数组b的元素进行排序
        lblShow.Text += "数组b排序后值：" + b[0] + "  " + b[1] + "  " + b[2] + "  " + b[3] + "  " + b[4] + "\n";
        Array.Reverse(b);        //反转数组b各元素的顺序
        lblShow.Text += "反转数组b的值：" + b[0] + "  " + b[1] + "  " + b[2] + "  " + b[3] + "  " + b[4] + "\n";
        int loc= Array.IndexOf(b, 18);//查找18在数组b中的索引
        lblShow.Text += "18是数组b中的第" + (loc+1) + "个元素"; //注意数组的索引从0开始

        }
    }
}
