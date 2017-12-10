using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test8_1
{
public delegate void Caculate(int x, int y);
public partial class Test8_1 : Form
{
    public Test8_1()
    {
        InitializeComponent();
    }

    public Caculate handler;  					//这是一个委托型的字段

    public void Product(int x, int y)
    {
        lblShow.Text += "a和b之积为：" + x * y;
    }
    public void Average(int x, int y)
    {
        lblShow.Text += "\na和b的平均值为：" + (x + y) / 2;
    }
    private void btnCalc_Click(object sender, EventArgs e)
    {
        int a = Convert.ToInt16(txtA.Text);
        int b = Convert.ToInt16(txtB.Text);
        
        handler  = new Caculate(Product);
        handler += new Caculate(Average);
        handler(a, b);
   }
}
}
