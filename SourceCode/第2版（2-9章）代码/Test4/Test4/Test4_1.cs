using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test4_1
{
    public partial class Test4_1 : Form
    {
        public Test4_1()
        {
            InitializeComponent();
        }

        private void Test4_1_Load(object sender, EventArgs e)
        {
            Book book1;     //声明一个Book对象book1
            book1 = new Book();   //为book1分配内存空间
            Book book2 = new Book();    //声明同时创建对象
            book1.title = "Visual C#.NET程序设计教程";  //修改对象的数据成员的值
            book1.price = 32;
            string strMsg=book1.GetMessage();     //调用对象的方法成员
            lblShow.Text = strMsg;
            book2.title = "数据结构";                 //修改对象的数据成员的值
            book2.price = 28;
            lblShow.Text += "\n\n" + book2.GetMessage();//调用对象的方法成员

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
