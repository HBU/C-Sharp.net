using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test8_1
{
    public delegate int Caculate(int x, int y);   //声明委托
    public partial class Test8_1 : Form
    {
        
        public Caculate handler;       	   //定义委托型的字段
        public Test8_1()
        {
            InitializeComponent();

        }

    private void btnCalc_Click(object sender, EventArgs e)
    {
            int a = Convert.ToInt32(txtNum1.Text);
             int b = Convert.ToInt32(txtNum2.Text);
            string test = "";
              MyMath math = new MyMath();
            //handler = new Caculate(math.Add);   //创建委托对象同时封装方法
            //lblShow.Text = "两数之和为：" + handler(a, b);   //通过委托对象调用方法

            //handler = new Caculate(math.Multiply);
            //lblShow.Text += "\n两数之积为：：" + handler(a, b);

            handler = new Caculate(math.Add);   //使用多路广播机制来创建调用列表
            handler += new Caculate(math.Multiply);
           
            lblShow.Text = "调用后的结果是：" + handler(a, b);                    //一次性调用列表中的方法

            //////Math.pow()

        }
    }
    class MyMath
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Multiply(int x, int y)
        {
            return x*y;
        }
    }

}
