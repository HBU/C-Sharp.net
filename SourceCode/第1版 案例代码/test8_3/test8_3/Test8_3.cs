using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace test8_3
{
    public partial class Test8_3 : Form
    {
        Grade g = new Grade();       	//创建班级对象
        School school = new School();  //创建学校对象

        public Test8_3()
        {
            InitializeComponent();
            school.subscribeEvent(g);  //5. 预订事件
        }
 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //学生报到登记
            Student s = new Student(txtName.Text,
                Convert.ToChar(txtSex.Text));
            g.Add(s);
            lblShow.Text = txtName.Text+"成功报到！";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            g.ProcessRegister();    //6. 新生注册,触发事件
            lblShow.Text = "已成功注册的学生名单如下：\n";
            for (int i = 0; i < school.Count;i++ )
            {
                lblShow.Text += String.Format("姓名：{0}，性别：{1}\n",school[i].name,school[i].sex.ToString());
            }
        }
    }
    class Student   								//学生类
    {
        public string name;
        public char sex;
        //构造函数
        public Student(string name, char sex)
        {
            this.name = name;
            this.sex = sex;
        }
    }
    //新生注册事件数据类
    class StudentEventArgs : EventArgs
    {
        private Student someone;
        public StudentEventArgs(Student s)  //构造函数
        {
            someone = s;
        }
        public Student student              //只读属性
        {
            get { return someone; }
        }
    }

    class Grade   //班级类，也是事件的发布者
    {
        private ArrayList list; 	//声明列表，用来保存本班已报到的学生信息
        //1. 定义新生注册事件
        public event EventHandler<StudentEventArgs> onNewStudent;
        //构造函数
        public Grade()
        {
            list = new ArrayList();
        }
        //新生s在班级名单上登记报到
        public void Add(Student s)
        {
            list.Add(s);
        }
        //注册到学校花名册，同时发布事件
        public void ProcessRegister()
        {
            foreach (Student s in list)
            {
                StudentEventArgs e = new StudentEventArgs(s);  	//创建事件参数
                if (onNewStudent != null && s != null)
                    onNewStudent(this, e);    				    //2. 触发事件 
            }
        }
    }
    class School   //学校类，表示学校的花名册，也是事件的接收者
    {
        private int students;    	//表示全校学生人数
        private ArrayList list;   	//声明列表，保存已注册的学生信息
        public School()      //构造函数
        {
            students = 0;
            list = new ArrayList();

        }
        //声明索引器
        public Student this[int index]
        {
            get
            {
                if (index < 0 || index >= list.Count)
                    return (Student)list[0];
                else
                    return (Student)list[index];
            }
        }
        //声明属性，返回全校学生人数
        public int Count
        {
            get { return students; }
        }
        //3. 声明事件函数
        private void Add_NewStudent(Object sender, StudentEventArgs e)
        {
            if (e.student != null)
            {
                students++;   			//学生人数增加1
                list.Add(e.student);	//把接收到的学生信息存入列表中
            }
        }
        //4. 预订新生注册事件
        public void subscribeEvent(Grade g)
        {
            g.onNewStudent += new EventHandler<StudentEventArgs>(Add_NewStudent);
        }
    }
}
