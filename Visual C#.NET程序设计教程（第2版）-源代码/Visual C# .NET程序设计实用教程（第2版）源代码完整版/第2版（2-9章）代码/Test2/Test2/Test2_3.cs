using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test2
{
    public partial class Test2_3 : Form
    {
        public Test2_3()
        {
            InitializeComponent();
        }
        struct Student
        {
            public int stuNo;
            public string stuName;
            public int age;
            public char sex;
        }

        private void Test2_3_Load(object sender, EventArgs e)
        {
            Student stu;//定义结构型变量s
            stu.stuNo = 1001;//为stu的成员变量stuNo赋值
            stu.stuName = "乔峰";//为stu的成员变量stuName赋值
            stu.age = 23;//为stu的成员变量age赋值
            stu.sex = '男';//为stu的成员变量sex赋值
            lblShow.Text = "学生信息:\n姓名：" + stu.stuName;//使用stu的成员变量stuName
            lblShow.Text += "\n学号：" + stu.stuNo;//使用stu的成员变量stuNo
            lblShow.Text += "\n性别：" + stu.sex;//使用stu的成员变量sex
            lblShow.Text += "\n年龄：" + stu.age;//使用stu的成员变量age
        }

    }
}
