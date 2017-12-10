using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Exp5_1 : Form
    {
        Student[] stus = new Student[10]; 
        public Exp5_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(textBox2.Text);
            double sub1 = Convert.ToDouble(textBox3.Text);
            double sub2 = Convert.ToDouble(textBox4.Text);
            Pupil p = new Pupil(textBox1.Text, age, sub1,sub2);
            Display(p);

        }
      
        private void Display(Student stu)
        {
            string type="";
            if (stu is Undergraduate) type = "大学生";
            else if (stu is MidStu) type = "中学生";
            else if (stu is Pupil) type = "小学生";
            lblShow.Text += string.Format("总人数：{0},姓名：{1},{2},平均成绩为：{3}\n", Student.number,stu.Name,type,stu.Average());
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(textBox2.Text);
            double sub1 = Convert.ToDouble(textBox3.Text);
            double sub2 = Convert.ToDouble(textBox4.Text);
            double sub3 = Convert.ToDouble(textBox5.Text);
            MidStu m = new MidStu(textBox1.Text, age, sub1, sub2,sub3);
            Display(m);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(textBox2.Text);
            double sub1 = Convert.ToDouble(textBox3.Text);
            double sub2 = Convert.ToDouble(textBox4.Text);
            Undergraduate u = new Undergraduate(textBox1.Text, age, sub1, sub2);
            Display(u);
        }

     
    }
    public abstract class Student
    {
        protected string name;
        protected int age;
        public static int number;
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
            number++;
        }
        public string Name { get { return name; } }
        public abstract double Average();
    }
    public class Pupil : Student
    {
        protected double chinese;
        protected double math;
        public Pupil(string name, int age, double chinese, double math):base(name, age)
        {
            this.chinese = chinese;
            this.math = math;

        }
        public override double Average()
        {
            return (chinese + math)/2;
        }
    }
    public class MidStu : Pupil
    {
        protected double english;
        public MidStu(string name, int age, double chinese, double math, double english)
            : base(name, age, chinese, math)
        {
            this.english = english;
        }
        public override double Average()
        {
            return (chinese + math + english) / 3;
        }
    }
    public class Undergraduate : Student
    {
        protected double requiredCourse ;
        protected double elective ;
        public Undergraduate(string name, int age, double course, double elec): base(name, age)
        {
            this.requiredCourse = course;
            this.elective = elec;
        }
        public override double Average()
        {
            return (requiredCourse + elective) / 2;
        }
    }
}
