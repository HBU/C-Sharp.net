using System;
using System.Windows.Forms;

namespace test4_1
{
    public partial class Test4_1 : Form
    {
        public Test4_1()
        {
            InitializeComponent();  
            
        }
        public void func(Student stu1)
        {
            
        }

        private void Test4_1_Load(object sender, EventArgs e)
        {
            Student stu1;  //声明一个Student对象stu1
            stu1 = new Student();  //为stu1分配内存空间
            Student stu2 = new Student(); //声明同时创建对象
            stu1.name = "令狐冲";//修改对象的数据成员的值
            stu1.age = 21;
            string strMsg = stu1.GetMessage();//调用对象的方法成员
            lblShow.Text = strMsg;
            stu2.name = "郭靖";//修改对象的数据成员的值
            stu2.age = 22;
            lblShow.Text += "\n" + stu2.GetMessage();//调用对象的方法成员
        }
    }
    
    //public class Student
    //{
    //    //定义类的数据成员 
    //    public string name;
    //    public int age;
    //    //定义类的方法成员
    //    public string GetMessage()
    //    {
    //        return string.Format("姓名：{0}，年龄：{1}岁。", this.name, this.age);
    //    }
    //}

}
