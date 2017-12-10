using System;
using System.Windows.Forms;

namespace test3_4
{
public partial class Test3_4 : Form
{
    public Test3_4()
    {
        InitializeComponent();
    }


    private void Test3_4_Load(object sender, EventArgs e)
    {
        int i, sum;
        i = 1;               //为循环变量赋初值
        sum = 0;
        while (i <= 100)     //循环条件
        {                    //循环体
            sum = sum + i;
            i++;             //改变循环变量的值
        }
        lblShow.Text = "1到100的自然数之和是" + sum;   //显示计算结果
    }
}
}
