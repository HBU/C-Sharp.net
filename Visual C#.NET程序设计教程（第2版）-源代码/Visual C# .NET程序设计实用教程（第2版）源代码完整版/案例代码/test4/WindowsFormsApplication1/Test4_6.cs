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
    public partial class Test4_6 : Form
    {
        Student stu;//声明一个Student的对象stu做为Test4_6类的成员
        public Test4_6()
        {
            InitializeComponent();
        }

        private void Test4_6_Load(object sender, EventArgs e)
        {
            stu = new Student();//实例化stu对象
            stu.name = "令狐冲";stu.age = 21;//对象赋初值
            txtName.Text = stu.name;//显示stu的字段值
            txtAge.Text = stu.age.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MidStu(stu);//调用MidStu方法，stu做为实参传入
            txtName.Text = stu.name;//显示调用MidStu方法后的stu字段值
            txtAge.Text = stu.age.ToString();
        }
        public void MidStu(Student student)
        {
            student.name = txtNameNew.Text;//修改传入的参数student对象的值
            student.age = Convert.ToInt32(txtAgeNew.Text); 
        }

        
    }

    public class Student
    {
        public string name;
        public int age;
        public string GetMessage()
        {
            return string.Format("姓名：{0}，年龄：{1}岁。", this.name, this.age);
        }
    }

}
