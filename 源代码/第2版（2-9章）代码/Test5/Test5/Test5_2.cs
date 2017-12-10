using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test5_2
{
    public partial class Test5_2 : Form
    {
        public Test5_2()
        {
            InitializeComponent();
        }

        private void btnCreat_Click(object sender, EventArgs e)
        {
            Undergraduate u = new Undergraduate();
            lblShow.Text = u.GetMessage();
            lblShow.Text += "\n\n" + u.Study();

            
        }

       
    }
    public class Student     			//这是一个基类
    {
        protected string name;          //基类的数据成员
        protected int age;  
        
        public  string Study()            //基类的方法
        {
            return string.Format("Student({0}):我今年{1}岁，我正在学习！", name, age);
        }
    }
    public class Undergraduate : Student   	//这是一个派生类
    {
        private string subject;        //派生类数据成员
        public Undergraduate()//:base("无名",0)
        {
            subject = "未知";
        }
       
        public string GetMessage()        //派生类方法
        {
            return string.Format("Undergraduate({0}):我今年{1}岁，我的专业是{2}！", name, age, subject);
        }
       
    }
}
