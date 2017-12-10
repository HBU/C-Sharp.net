using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test4_6
{
    public partial class Test4_6 : Form
    {
        Book book;//声明一个Book的对象book做为Test4_6类的成员
        public Test4_6()
        {
            InitializeComponent();
        }

        private void Test4_6_Load(object sender, EventArgs e)
        {
            book = new Book();//实例化book对象
            book.title = "Visual C#.NET程序设计教程"; book.price = 32;//对象赋初值
            txtTitle.Text = book.title;//显示book的字段值
            txtPrice.Text = book.price.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MidBook(book);//调用MidBook方法，book做为实参传入
            txtTitle.Text = book.title;//显示调用MidBook方法后的book字段值
            txtPrice.Text = book.price.ToString();
        }
        public void MidBook(Book newBook)
        {
            newBook.title = txtTitleNew.Text;//修改传入的参数student对象的值
            newBook.price = Convert.ToInt32(txtPriceNew.Text); 
        }

        
    }

    public class Book
    {
        //定义类的数据成员 
        public string title;
        public double price;
        //定义类的方法成员
        public string GetMessage()
        {
            return string.Format("书名：{0}，价格：{1}元。", this.title, this.price);
        }
    }

}
