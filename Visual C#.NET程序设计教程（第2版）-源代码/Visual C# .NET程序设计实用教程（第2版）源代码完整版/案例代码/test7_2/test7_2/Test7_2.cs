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

        class MyException : Exception
        {
            public MyException(string str1) : base(str1) { }
            public MyException(string str1, Exception e) : base(str1, e) { }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                float price = Convert.ToSingle(txtPrice.Text);
                int amount = Convert.ToInt32(txtAmount.Text);
                lblShow.Text += amount * price + "元";
                if (price < 0 || amount < 0)
                    throw new MyException("警告！单价或数量不能为负数");
            }
            catch (MyException e1)
            {
                lblShow.Text = e1.Message;         
            }
            catch (Exception ex)
            {
                lblShow.Text = ex.Message;
            }
        }
    }
}
