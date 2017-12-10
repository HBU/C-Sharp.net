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
    public partial class Test6_4 : Form
    {
        Pet<Animal> myPet = new Pet<Animal>();
        public Test6_4()
        {
            InitializeComponent();
            //ArrayList list = new ArrayList();
            //list.Add(44);
            //list.Add("mystring");
            //list.Add(new Student("",1001));

            //foreach (object o in list)
            //{
            //    Console.WriteLine((int)o);
            //}

            //List<Student> listStu = new List<Student>();
            //Student stu1 = new Student("令狐冲", 101); //创建一个Student对象
            //Student stu2 = new Student("郭靖", 102); //创建一个Student对象
            //listStu.Add(stu1);  //添加到students泛型集合
            //listStu.Add(stu2);  //添加到students泛型集合

            

            //Student newStu = listStu[0];  //使用索引访问，无需类型转换
            //lblShow.Text = newStu.ShowMsg();

            //foreach (Student stu in listStu)
            //{
            //    lblShow.Text = stu.ShowMsg(); //遍历时不需要类型转换

            //}

            //listStu.RemoveAt(0);//利用索引删除


            //Dictionary<int, Student> dicStu =new Dictionary<int, Student>();
            //Student stu1 = new Student("令狐冲", 101); //创建一个Student对象
            //Student stu2 = new Student("郭靖", 102); //创建一个Student对象
            //dicStu.Add(101, stu1);  //添加到dicStu泛型集合
            //dicStu.Add(102, stu2);  //添加到dicStu泛型集合



            //Student newStu = dicStu[101];  //通过Key获取元素，无需类型转换
            //lblShow.Text = newStu.ShowMsg();

            //foreach (Student stu in dicStu.Values)//遍历Values
            //{
            //    lblShow.Text = stu.ShowMsg(); //遍历时不需要类型转换

            //}

            //dicStu.Remove(101);//通过Key删除元素







        }

        private void btnDog_Click(object sender, EventArgs e)
        {
            myPet.Animals.Add(new Dog(txtName.Text));
            lblShow.Text += string.Format("\n添加Dog:{0}成功",txtName.Text);
        }

        private void btnSmallDog_Click(object sender, EventArgs e)
        {
            myPet.Animals.Add(new SmallDog(txtName.Text));
            lblShow.Text += string.Format("\n添加SmallDog:{0}成功", txtName.Text);
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            myPet.Animals.Add(new Cat(txtName.Text));
            lblShow.Text += string.Format("\n添加Cat:{0}成功", txtName.Text);

        }

        private void btnFeed_Click(object sender, EventArgs e)
        {
            lblShow.Text = myPet.FeedTheAnimals();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Pet<Animal> myPet = new Pet<Animal>();
        //    myPet.Animals.Add(new Dog());
        //    myPet.Animals.Add(new Cat());
        //    myPet.Animals.Add(new SmallDog());
        //    foreach (Animal a in myPet.Animals)
        //    {
        //        lblShow.Text += a.Eat();
        //    }
        //    Person<int, string> stu = new Person<int, string>(1001, "令狐冲");
        //    lblShow.Text += "\n" + stu.ShowMsg();
        //    Person<string, string> teacher = new Person<string, string>("教授", "洪七公");
        //    lblShow.Text += "\n" + teacher.ShowMsg();

        //}
    }

    public abstract class Animal
    {
        protected string name;
        public Animal(string name)
        {
            this.name = name;
        }
        public abstract string Eat();
    }
    public abstract class Plant
    {
        public abstract string Eat();
    }
    public abstract class Rose:Plant
    {
        public override string Eat()
        {
            return "Rose:我要喝水！";
        }
    }
    public class Dog : Animal
    {
        public Dog(string name) : base(name) { }
        public override string Eat()
        {
            return string.Format("{0}:我是Dog，我要吃骨头！",name);
        }
    }
    public class Cat : Animal
    {
        public Cat(string name) : base(name) { }
        public override string Eat()
        {
            return string.Format("{0}:我是Cat:我要吃鱼！", name);
        }
    }
    public class SmallDog : Dog
    {
        public SmallDog(string name) : base(name) { }
        public override string Eat()
        {
            return string.Format("{0}:我是SmallDog:我要吃狗粮！", name);
        }
    }
    public class Pet<T> where T : Animal
    {
        private List<T> animals = new List<T>();
        public List<T> Animals
        {
            get
            {
                return animals;
            }
        }

        public string FeedTheAnimals()
        {
            string msg=string.Empty;
            foreach (T animal in animals)
            {
                msg+="\n"+animal.Eat();
            }
            return msg;
        }


        //public IEnumerator<T> GetEnumerator()
        //{
        //    return animals.GetEnumerator(); ;
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return animals.GetEnumerator();
        //}


    }
    public class MyPet<T> : Pet<T> where T:Dog
    {
    }
    public class Person<T1, T2>
    {
        T1 t1;
        T2 t2;
        public Person(T1 x, T2 y)
        {
            t1 = x;
            t2 = y;
        }
        public string ShowMsg()
        {
            int a = 5,b = 8;
            Swap<int>(ref a, ref b);
            return string.Format("{0}:{1}", t1, t2);
        }
        void Swap<T>(ref T t1, ref T t2)
        {
            T temp;
            temp = t1; t1 = t2; t2 = temp;
        }
    }
}
