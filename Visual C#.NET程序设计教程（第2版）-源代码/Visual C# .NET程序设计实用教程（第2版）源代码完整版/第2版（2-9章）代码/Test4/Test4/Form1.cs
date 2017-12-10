using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test4_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Book book1;
            book1= new Book();
            Book book2 = new Book();

            book1.title = "Visual C#.NET程序设计教程";
            book1.price = 32;
            book1.GetMessage();
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
            return string.Format("书名：{0}，价格：{1}岁。", this.title, this.price);
        }
    }
    class Calculate
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public string DisPlay(int x, int y)
        {
            return string.Format("{0}+{1}={2}", x, y, Add(x, y));      ///调用自身类的Add方法
        }
    }


}
