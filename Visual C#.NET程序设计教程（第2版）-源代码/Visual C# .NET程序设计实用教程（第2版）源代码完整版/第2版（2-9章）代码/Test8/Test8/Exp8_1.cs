using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exp8_1
{
    public delegate int Caculate(int x, int y);   //声明委托
    public partial class Exp8_1 : Form
    {

        public Caculate handler; //定义委托型的字段
        MyMath math = new MyMath();
        int operand1;//第1操作数
        int operand2;//第2操作数
        bool isContinue=true;//是否连续输入
        public Exp8_1()
        {
            InitializeComponent();
            
        }
        //数字按钮
        private void btnNum_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btn = (Button)sender;
                if(isContinue) 
                    txtResult.Text += btn.Text;
                else
                {
                    isContinue=true;//输入一个数字后，下一个数字为连续输入
                    txtResult.Text=btn.Text;
                }

                
                
            }
        }
        //运算符
        private void btnCalc_Click(object sender, EventArgs e)
        {
            isContinue=false;//点击运算符后 ，下一个数字不是连续输入
            if (handler == null)//没有委托运算符时，为第1个操作数
            {
                operand1 = Convert.ToInt32(txtResult.Text);
            }
            else//将该运算符之前委托的运算先计算出来
            {
                operand2 = Convert.ToInt32(txtResult.Text);
                operand1 = handler(operand1, operand2);//运算结果做为下一次运算的第1操作数
                txtResult.Text = operand1.ToString();
            }            
            if (sender is Button)
            {
                
                Button btn = (Button)sender;               
                switch (btn.Text)//把该运算符对应的运算添加到委托中
                {
                    case "+":
                        handler += new Caculate(math.Add);break;
                    case "-":
                        handler += new Caculate(math.Sub); break;
                    case "*":
                        handler += new Caculate(math.Mul); break;
                    case "/":
                        handler += new Caculate(math.Div); break; 
                    case "=":
                        handler = null;break;
                }
            }
        }
    }
    class MyMath
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Mul(int x, int y)
        {
            return x * y;
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }
        public int Div(int x, int y)
        {
            return x / y;
        }

    }
}
