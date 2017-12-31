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
    public partial class Test4_9 : Form
    {
        public Test4_9()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Student_1 stu;
            if (txtAge.Text == "")
            {
                if (txtName.Text == "")
                {
                    lblShow.Text = "调用无参构造函数(默认构造函数):";
                    stu = new Student_1();
                }
                else
                {
                    lblShow.Text = "调用有一个参数的构造函数:";
                    stu = new Student_1(txtName.Text);
                }
            }
            else
            {
                int age=Convert.ToInt32(txtAge.Text);
                lblShow.Text = "调用有两个参数的构造函数:";
                stu=new Student_1(txtName.Text,age);
            }
            lblShow.Text+= "\n\n"+stu.GetMessage();
        }

        
    }
    public class Student_1
    {
        //定义类的数据成员 
        private string name;
        private int age;
        //定义类的方法成员
        public Student_1():this("无名",20){ }
        public Student_1(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Student_1(string name) : this(name, 20) { }
        public string GetMessage()
        {
            return string.Format("姓名：{0}，年龄：{1}岁。", this.name, this.age);
        }
    }
}
