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
    public partial class Test5_2 : Form
    {
        public Test5_2()
        {
            InitializeComponent();
        }

        private void btnCreat_Click(object sender, EventArgs e)
        {
            Dog d = new Dog();
        }

       
    }
    public class Animal     			//这是一个基类
    {
        protected string name;          //基类的数据成员
        protected int age;
        public Animal(string name,int age)
        {
            this.name=name;
            this.age = age;
        }
        public virtual string Eat()            //基类的方法
        {
            return string.Format("Animal({0}):我现在饿了，我要吃东西！",name);
        }
    }
    public class Dog : Animal   	//这是一个派生类
    {
        private string type;        //派生类数据成员
        public Dog():base("无名",0)
        {
            type = "未知";
        }
        public Dog(string name, int age, string type):base(name,age)
        {
            this.type = type;
        }
        public string GetMessage()        //派生类方法
        {
            return string.Format("Dog({0}):我的品种是{1},今年{2}岁了", name,type,age);
        }
        public override string Eat()            //派生类覆盖基类方法
        {
            return string.Format("Dog({0}):我现在饿了，我要吃骨头！", name);
        }
    }
}
