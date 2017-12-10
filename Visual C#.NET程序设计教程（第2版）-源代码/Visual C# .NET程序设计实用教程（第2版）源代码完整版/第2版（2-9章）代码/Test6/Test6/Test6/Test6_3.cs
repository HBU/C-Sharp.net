using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;
namespace Test6_3
{
    public partial class Test6_3 : Form
    {
        BookStack bookstack = new BookStack(3); // 创建一个容量为 3 的书架
        public Test6_3()
        {
            InitializeComponent();
         


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(txtIndex.Text)-1;//索引从0开始
            Book book = new Book(txtTitle.Text); // 创建1本图书
            bookstack[index] = book; // 向书架加载图书
            lblShow.Text = string.Format("图书添加成功！");               

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(txtIndex.Text)-1;
            Book book = bookstack[index];//按索引检索
            if (book != null)
                lblShow.Text = string.Format("第{0}本图书的书名是：{1}", index+1, book.Title);
            else lblShow.Text = string.Format("没有第{0}本书！", index+1); 

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Book pho = bookstack[txtTitle.Text];// 按名称检索
            if (pho != null)
                lblShow.Text = string.Format("找到书名为：{0} 的图书！",  pho.Title);
            else lblShow.Text = string.Format("没有找到书名为：{0} 的图书！", txtTitle.Text); 

        }
    }
    class Book//定义一个图书类
    {
        string _title;
        public Book(string title)
        {
            this._title = title;
        }
        public string Title  //只读属性，返回图书名称
        {
            get
            {
                return _title;
            }
        }
    }
    class BookStack  //定义一个书架类
	{
		
		Book[] books;// 该数组用于存放照片
        public BookStack(int capacity) //构造函数，初始化指定大小的books数组
		{
			books = new Book[capacity];
		}
    public Book this[int index] //带有 int参数的Book读/写索引器
    {
        get
        {
                
            if (index < 0 || index >= books.Length)// 验证索引范围
            {
                return null; // 使用 null 指示失败
            }
            return books[index]; // 对于有效索引，返回请求的图书
        }
        set
        {
            if (index < 0 || index >= books.Length)
            {
                return;
            }
            books[index] = value;
        }
    }
    public Book this[string title]//带有string参数的Book只读索引器
    {
        get
        {                
            foreach (Book p in books)// 遍历数组中的所有图书
            {
                    
                if (p.Title == title)// 将图书的名称与索引器参数进行比较
                    return p;
            }               
                
            return null;// 使用 null 指示失败
        }
    }
    }

    public interface IAddress
    {
        string this[int index] { get; set; }  	//声明索引器
        string Address { get; set; }       		//声明属性
        string Answer();              		//声明方法
    }
    



}
