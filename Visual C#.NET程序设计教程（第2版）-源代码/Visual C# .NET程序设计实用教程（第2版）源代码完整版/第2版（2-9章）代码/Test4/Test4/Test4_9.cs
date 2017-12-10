using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test4_9
{
    public partial class Test4_9 : Form
    {
        public Test4_9()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Book book;
            if (txtPrice.Text == "")
            {
                if (txtTitle.Text == "")
                {
                    lblShow.Text = "调用无参构造函数(默认构造函数):";
                    book = new Book();
                }
                else
                {
                    lblShow.Text = "调用有一个参数的构造函数:";
                    book = new Book(txtTitle.Text);
                }
            }
            else
            {
                double price=Convert.ToDouble(txtPrice.Text);
                lblShow.Text = "调用有两个参数的构造函数:";
                book = new Book(txtTitle.Text, price);
            }
            lblShow.Text+= "\n"+book.GetMessage();
        }

        private void Test4_9_Load(object sender, EventArgs e)
        {

        }

        
    }
    public class Book
    {
        //定义类的数据成员 
        private string title;
        private double price;
        //定义类的方法成员
        public Book():this("无名",20){ }
        public Book(string title, double price)
        {
            this.title = title;
            this.price = price;
        }
        public Book(string title) : this(title, 20) { }
        public string GetMessage()
        {
            return string.Format("书名：{0}\n价格：{1}元。", this.title, this.price);
        }
    }
}
