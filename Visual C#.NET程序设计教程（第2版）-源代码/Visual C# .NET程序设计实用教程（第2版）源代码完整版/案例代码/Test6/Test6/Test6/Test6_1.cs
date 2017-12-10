using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Test6
{
    public partial class Test6_1 : Form
    {
        ArrayList AlStudents = new ArrayList(); //创建一个拥有默认初始容量的ArrayList集合
        public Test6_1()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    ArrayList AlStudents = new ArrayList(); //创建一个拥有默认初始容量的ArrayList集合
        //    ArrayList AlTeachers = new ArrayList(5); //创建一个容量为5的ArrayList集合
        //    Student stu1 = new Student("令狐冲", 21); //创建一个Student对象
        //    Student stu2 = new Student("郭靖", 22); //创建一个Student对象
        //    Student stu3 = new Student("杨过", 20); //创建一个Student对象
        //    AlStudents.Add(stu1);  //在ArrayList集合Students中添加该对象
        //    AlStudents.Add(stu2);  //在ArrayList集合Students中添加该对象
        //    AlStudents.Add(stu3);  //在ArrayList集合Students中添加该对象

        //    //AlStudents.Remove(stu2);//通过指定对象删除对象

        //    AlStudents.RemoveAt(1); //通过索引删除对象
        //    AlStudents.RemoveAt(1); //通过索引删除对象
        //    AlStudents.RemoveAt(1); //通过索引删除对象
        //    AlStudents.Insert(1, stu2);

        //    for (int i = 0; i < AlStudents.Count; i++)
        //    {
        //        Student stuFor = (Student)AlStudents[i];
        //        lblShow.Text += "\n" + stuFor.ShowMsg();
        //    }


        //    foreach (object stuo in AlStudents)
        //    {
        //        Student stuForeach = (Student)stuo;
        //        lblShow.Text += "\n" + stuForeach.ShowMsg();
        //    }
        //}

        private void Test6_1_Load(object sender, EventArgs e)
        {
        
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int stuNo=Convert.ToInt32(txtStuNo.Text);
            Student stu=new Student(txtName.Text,stuNo);
            AlStudents.Add(stu);//添加
            lblShow.Text="";
            Foreach();//遍历

        
        }
        private void Foreach()
        {
             foreach (object stuo in AlStudents)
            {
                Student stuForeach = (Student)stuo;
                lblShow.Text += "\n" + stuForeach.ShowMsg();
            }
        }
        private void btnForeach_Click(object sender, EventArgs e)
        {
            lblShow.Text = "";
            Foreach();//遍历
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int stuNo = Convert.ToInt32(txtStuNo.Text);
            int index = Convert.ToInt32(txtIndex.Text);
            Student stu = new Student(txtName.Text, stuNo);
            AlStudents.Insert(index, stu);//插入
            lblShow.Text = "";
            Foreach();//遍历
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(txtIndex.Text);
            AlStudents.RemoveAt(index);//删除
            lblShow.Text = "";
            Foreach();//遍历
        }
    }
    public class Student
    {
        string name;
        int stuNo;
        public Student(string name,int no)
        {
            this.name=name;
            this.stuNo=no;
        }
        public string ShowMsg()
        {
            return string.Format("学号：{0}，姓名：{1}！", stuNo,name);
        }
  
   }
}
