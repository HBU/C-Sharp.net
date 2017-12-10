using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test4_1
{
    public partial class Test4_3 : Form
    {
        public Test4_3()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Swaper s = new Swaper();        		//创建对象               
            int a = Convert.ToInt32(txtOp1.Text);
            int b = Convert.ToInt32(txtOp2.Text);
            lblShow.Text=s.Swap(a, b);                    		//调用并传递参数
            //lblShow.Text = s.Swap(ref a, ref b);
            lblShow.Text += string.Format("\n\n主调方法：调用之后：a={0}，b={1}", a, b); 
            txtOp1.Text=a.ToString();   //把调用后的实参的值重新赋值到文本框中
            txtOp2.Text=b.ToString();

        }
    }
    class Swaper
    {
        public string Swap(int x, int y)      		//被调方法，其中x和y是形参
        //public string Swap(ref int x,ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
            return string.Format("被调方法：交换之后：x={0}，y={1}", x, y);
        }
    }
   
 
}
