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
    public partial class Test5_1 : Form
    {
        //创建Person型的数组对象，用来记录5个人的信息
        Person[] ps = new Person[5]; 

        public Test5_1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Gender sex=txtSex.Text=="男"?Gender.男:Gender.女;
           // int age=Convert.ToInt32(txtAge.Text);
            //用Person.number获到当前的总人数，并创建一个新的Person对象
           // ps[Person.number] = new Person(txtName.Text, sex, age);
            ps[0] = new Person("张伟", Gender.男, 20);
            ps[1] = new Person("李静", Gender.女, 21);
            ps[2] = new Person("黄薇", Gender.女, 19);
            ps[3] = new Person("赵恒", Gender.男, 22);
            ps[4] = new Person("钱沿", Gender.男, 20);

            Person.number=5;//人数增加一个
            lblShow.Text = string.Format("添加成功：{0}人",Person.number);
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            lblShow.Text += string.Format("\n男生人数：{0}", Person.NumberMales());
            lblShow.Text += string.Format("\n女生人数：{0}", Person.NumberFemales);
            lblShow.Text += string.Format("\n学生名单如下：\n");
            foreach (Person p in ps)
            {                
                if(p!=null)lblShow.Text += string.Format("{0}  ", p.Name);
            }
          }
    }
    public enum Gender { 男, 女 };
    public class Person
    {
        //私有静态字段，分别统计男、女人数
        private static int males;
        private static int females;
        public static int number; //公共静态字段，统计总人数
        //公共字段，描述个人信息
        public string Name;
        public Gender Sex;
        public int Age;
        //构造函数，用来初始化对象
        public Person(string name, Gender sex, int age)
        {
            Name = name;
            Sex = sex;
            Age = age;
            if (sex == Gender.男) males++;
            if (sex == Gender.女) females++;
        }
        static Person()
        {
            males = 0;
            females = 0;
        }
        //静态方法，返回男生人数
        public static int NumberMales()
        {
            return males;
        }
        //静态方法属性，返回女生人数
        public static int NumberFemales
        {
            get { return females; }
        }
    }

}
