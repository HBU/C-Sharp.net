using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test5_4
{
    public partial class Test5_4 : Form
    {
        public Test5_4()
        {
            InitializeComponent();
        }

        private void btnCtBase_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(txtAge.Text);
            Student s = new Student(txtName.Text, age);
            StudentStudy(s);
        }

        private void btnCtChild_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(txtAge.Text);
            Undergraduate d = new Undergraduate(txtName.Text, age, txtSubject.Text);
            StudentStudy(d);
        }
        private void StudentStudy(Student stu)
        {
            lblShow.Text = stu.Study();
        }

      
    }
    public class Student     			//这是一个基类
    {
        protected string name;          //基类的数据成员
        protected int age;
        public Student(string name, int age)  //基类带参构造函数
        {
            this.name = name;
            this.age = age;
        }
        public virtual string Study()            //基类的方法
        {
            return string.Format("Student({0}):我今年{1}岁，我正在学习！", name, age);
        }
    }
    public class Undergraduate : Student   	//这是一个派生类
    {
        private string subject;        //派生类数据成员
        public Undergraduate(string name, int age, string subject):base(name, age)  //派生类的带参构造函数         
        {
            this.subject = subject;
        }
        public override string Study()            //派生类覆盖基类方法
        {
            return string.Format("Undergraduate({0}):我今年{1}岁，我正在学习{2}专业！", name, age, subject);
        }
    }
}
