using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test5_1
{
    public partial class Test5_1 : Form
    {
        //创建Books型的数组对象，用来记录5本图书的信息
        Books[] bs = new Books[5]; 

        public Test5_1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //cbbType.SelectedIndex表示组合框中选择的项的索引，第一项的索引为0
            Type type=cbbType.SelectedIndex==0?Type.Compute:Type.Novel;
            double price = Convert.ToDouble(txtPrice.Text);
            //用Books.count获到当前的图书数目，以此做为索引号，并创建一个新的Books对象
            bs[Books.count] = new Books(txtTitle.Text, type, price);


            Books.count++;//图书数量增加一个
            lblShow.Text = string.Format("添加成功：{0}本书", Books.count);
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            lblShow.Text = string.Format("\n计算机类图书总数：{0}", Books.NumberComputes());
            lblShow.Text += string.Format("\n小说类图书总数：{0}", Books.NumberNovels);
            lblShow.Text += string.Format("\n图书名单如下：\n");
            foreach (Books b in bs)
            {                
                if(b!=null)lblShow.Text += string.Format("{0}  ", b.title);
            }
          }
    }
    public enum Type { Compute, Novel };
    public class Books
    {
        //私有静态字段，分别统计计算机类和小说类的书目数量
        private static int compute;
        private static int novel;
        public static int count; //公共静态字段，统计总图书数量
        //公共字段，描述书目信息
        public string title;
        public Type type;
        public double price;
        //构造函数，用来初始化对象
        public Books(string title, Type type, double price)
        {
            this.title = title;
            this.type = type;
            this.price = price;
            if (type == Type.Compute) compute++;
            if (type == Type.Novel) novel++;
        }
        //静态构造函数，用来初始化静态成员
        static Books()
        {
            compute = 3;
            novel = 2;
        }
        //静态方法，返回计算机类图书数量
        public static int NumberComputes()
        {
            return compute;
        }
        //静态方法属性，返回小说类图书数量
        public static int NumberNovels
        {
            get { return novel; }
        }
    }

}
