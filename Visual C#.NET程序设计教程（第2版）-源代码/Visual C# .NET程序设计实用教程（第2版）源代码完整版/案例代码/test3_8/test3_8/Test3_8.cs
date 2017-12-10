using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test3_8
{
public partial class Test3_8 : Form
{
    public Test3_8()
    {
        InitializeComponent();
    }

    private void Test3_8_Load(object sender, EventArgs e)
    {
        lblShow.Text = "九九乘法表：\n";
        for(int i = 1; i<=9;i++)
        {
            for (int j = 1; j <= i; j++)
            {
                lblShow.Text += String.Format("{0}×{1}＝{2,-2:D}  ", i, j, i * j);
                /*说明：在格式字符“{2,-2:D}”中，第一个“2”表示索引，
                    “-2：D”表示以左对齐方式输出同时占2个字符位，
                    如果参数不足2位，将自动显示空格
                    */
            }
            lblShow.Text += "\n";
        }
    }
}
}
