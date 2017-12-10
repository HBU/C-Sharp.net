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
    public partial class Test6_2 : Form
    {
        Hashtable htStudents = new Hashtable(); //创建一个拥有默认初始容量、增长因子的Hashtable集合
        public Test6_2()
        {
            InitializeComponent();
            
            Queue q = new Queue(20,3.0f);
            q.Enqueue("令狐冲");
            q.Enqueue("郭靖");
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());


            Stack s = new Stack();
            s.Push("令狐冲");
            s.Push("郭靖");
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());



           

        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int stuNo = Convert.ToInt32(txtStuNo.Text);
            Student stu = new Student(txtName.Text, stuNo);
            htStudents.Add(stuNo,stu);//添加
            lblShow.Text = "";
            Foreach();//遍历


        }
        private void Foreach()
        {
            //foreach (object stuo in htStudents.Keys)
            //{
            //    int stuNo  = (int)stuo;
            //    Student stu = (Student)htStudents[stuNo];
            //    lblShow.Text += "\n" + stu.ShowMsg();
            //}
            foreach (object stuo in htStudents.Values)
            {
                Student stu = (Student)stuo;
                lblShow.Text += "\n" + stu.ShowMsg();
            }
        }
        private void btnForeach_Click(object sender, EventArgs e)
        {
            lblShow.Text = "";
            Foreach();//遍历
        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int key = Convert.ToInt32(txtKey.Text);
            htStudents.Remove(key);//删除
            lblShow.Text = "";
            Foreach();//遍历
        }
    }
}
