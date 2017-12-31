using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Test6_1
{
    public partial class Test6_1 : Form
    {
        ArrayList AlBooks = new ArrayList(); //创建一个拥有默认初始容量的ArrayList集合
        public Test6_1()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    ArrayList AlBooks = new ArrayList(); //创建一个拥有默认初始容量的ArrayList集合
        //    ArrayList AlStudent = new ArrayList(5); //创建一个容量为5的ArrayList集合
        //    Book bk1 = new Book("Visual C#.NET程序设计教程", 32); //创建一个Book对象
        //    Book bk2 = new Book("数据结构", 28); //创建一个Book对象
        //    Book bk3 = new Book("大学计算机应用基础", 32); //创建一个Book对象
        //    AlBooks.Add(bk1);  //在ArrayList集合AlBooks中添加该对象
        //    AlBooks.Add(bk2);  //在ArrayList集合AlBooks中添加该对象
        //    AlBooks.Add(bk3);  //在ArrayList集合AlBooks中添加该对象

        //    //AlStudents.Remove(stu2);//通过指定对象删除对象

        //    AlBooks.RemoveAt(1); //通过索引删除对象
        //    AlBooks.RemoveAt(1); //通过索引删除对象
        //    AlBooks.RemoveAt(1); //通过索引删除对象
        //    AlBooks.Insert(1, bk1);

        //    for (int i = 0; i < AlBooks.Count; i++)
        //    {
        //        Book bkFor = (Book)AlBooks[i];
        //        lblShow.Text += "\n" + bkFor.GetMessage();
        //    }


        //    foreach (object bko in AlBooks)
        //    {
        //        Book bkForeach = (Book)bko;
        //        lblShow.Text += "\n" + bkForeach.GetMessage(); 
        //    }
        //}

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double price = Convert.ToDouble(txtPrice.Text);
            Book bk = new Book(txtTitle.Text, price);
            AlBooks.Add(bk);//添加
            lblShow.Text="";
            Foreach();//遍历

        
        }
        private void Foreach()
        {
             foreach (object bkObj in AlBooks)
            {
                Book bkForeach = (Book)bkObj;
                lblShow.Text += "\n" + bkForeach.GetMessage();
            }
        }
        private void btnForeach_Click(object sender, EventArgs e)
        {
            lblShow.Text = "";
            Foreach();//遍历
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            double price = Convert.ToDouble(txtPrice.Text);            
            int index = Convert.ToInt32(txtIndex.Text);
            Book bk = new Book(txtTitle.Text, price);
            AlBooks.Insert(index, bk);//插入
            lblShow.Text = "";
            Foreach();//遍历
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(txtIndex.Text);
            AlBooks.RemoveAt(index);//删除
            lblShow.Text = "";
            Foreach();//遍历
        }
    }
    public class Book
    {
        private string title;
        private double price;        
        public Book(string title, double price)
        {
            this.title = title;
            this.price = price;
        }
        public string GetMessage()
        {
            return string.Format("书名：{0}\n价格：{1}元。", this.title, this.price);
        }
    }
}
