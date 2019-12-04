using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test7_2
{
    public partial class Test7_2 : Form
    {
        public Test7_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float price = Convert.ToSingle(txtPrice.Text);
            int amount = Convert.ToInt32(txtAmount.Text);
            lblShow.Text = amount * price + "元";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                float price = Convert.ToSingle(txtPrice.Text);
                int amount = Convert.ToInt32(txtAmount.Text);
                lblShow.Text = amount * price + "元";
            }
            catch
            {

            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                float price = Convert.ToSingle(txtPrice.Text);
                int amount = Convert.ToInt32(txtAmount.Text);
                lblShow.Text = amount * price + "元";
                if (price < 0 || amount < 0)
                {
                        throw new MyException("警告！单价或数量不能为负数");
                }
                   
            }
            catch (MyException e1) //抛出自定义异常
            {
                lblShow.Text = e1.Message;         
            }
            catch (FormatException fe)//抛出系统异常:非整形数字
            {
                lblShow.Text = fe.Message;
            }
            catch (OverflowException oe)//抛出系统异常：数字过大
            {
                lblShow.Text = oe.Message;
            }
            catch (Exception ex)//抛出系统异常：不是数字类型等
            {
                lblShow.Text = ex.Message;
            }
        }

        class MyException : Exception  //自定义异常
        {
            public MyException(string str1) : base(str1) { }
            public MyException(string str1, Exception e) : base(str1, e) { }
        }

    }
}
