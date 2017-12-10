using System;
using System.Windows.Forms;

namespace Test5_3
{
    public partial class Test5_3 : Form
    {
        public Test5_3()
        {
            InitializeComponent();
        }

        private void btnCreat_Click(object sender, EventArgs e)
        {
            Undergraduate u;
            if (txtName.Text == "") u = new Undergraduate();
            else
            {
                int age = Convert.ToInt32(txtAge.Text);
                u = new Undergraduate(txtName.Text, age, txtSubject.Text);
            }
            lblShow.Text = u.GetMessage();
            lblShow.Text += "\n\n" + u.Study();
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
        public string Study()            //基类的方法
        {
            return string.Format("Student({0}):我今年{1}岁，我正在学习！", name, age);
        }
    }
    public class Undergraduate : Student   	//这是一个派生类
    {
        private string subject;        //派生类数据成员
        public Undergraduate(): base("无名", 0)          //派生类的默认构造函数
        {
            subject = "未知";
        }
        public Undergraduate(string name, int age, string subject):base(name, age)  //派生类的带参构造函数         
        {
            this.subject = subject;
        }
        public string GetMessage()        //派生类方法
        {
            return string.Format("Undergraduate({0}):我今年{1}岁，我的专业是{2}！", name, age, subject);
        }
        //public override string Study()            //派生类覆盖基类方法
        //{
        //    return string.Format("Undergraduate({0}):我今年{1}岁，我正在学习{2}专业！", name,age,subject);
        //}
    }
}
