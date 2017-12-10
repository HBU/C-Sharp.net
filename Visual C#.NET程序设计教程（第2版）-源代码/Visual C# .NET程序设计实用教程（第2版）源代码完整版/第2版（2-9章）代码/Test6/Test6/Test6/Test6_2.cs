using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace Test6_2
{
    public partial class Test6_2 : Form
    {
        Hashtable htBooks = new Hashtable(); //创建一个拥有默认初始容量、增长因子的Hashtable集合
        public Test6_2()
        {
            InitializeComponent();
            
            //Book bk=new Book(1001,"Visual C#.NET程序设计教程",32);
            //htBooks.Add(1001, bk);
            //Book stu2 = (Book)htBooks[1001];     //通过key获取元素
            //lblShow.Text = stu2.GetMessage();




           

        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int bookId = Convert.ToInt32(txtBookId.Text);
            double price = Convert.ToDouble(txtPrice.Text);
            Book bk = new Book(bookId, txtTitle.Text, price);
            htBooks.Add(bookId, bk);//添加
            lblShow.Text = "";
            Foreach();//遍历


        }
        private void Foreach()
        {
            foreach (object bkOject in htBooks.Keys)
            {
                int bookId = (int)bkOject;
                Book bk = (Book)htBooks[bookId];
                lblShow.Text += bk.GetMessage();
            }
            //foreach (object bkOject in htBooks.Values)
            //{
            //    Book bk = (Book)bkOject;
            //    lblShow.Text += bk.GetMessage();
            //}
        }
        private void btnForeach_Click(object sender, EventArgs e)
        {
            lblShow.Text = "";
            Foreach();//遍历
        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int key = Convert.ToInt32(txtKey.Text);
            htBooks.Remove(key);//删除
            lblShow.Text = "";
            Foreach();//遍历
        }
    }
    public class Book
    {
        private int bookId;
        private string title;
        private double price;
        public Book(int bookId,string title, double price)
        {
            this.bookId = bookId;
            this.title = title;
            this.price = price;
        }
        public string GetMessage()
        {
            return string.Format("编号：{0}\n 书名：{1} 价格：{2}元\n", this.bookId,this.title, this.price);
        }
    }
}
