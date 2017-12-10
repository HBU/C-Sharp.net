using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student m = new Student("令狐冲",21);
            Student stu = new Student("郭靖");
            Console.WriteLine( m.GetMessage());
        }
    }
    public class Student
    {
        //定义类的数据成员 
        public string name;
        public int age;
        //定义类的方法成员
        public Student()
        {
            name = "无名";
            age = 20;
        }
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Student(string name):this(name,20){ }
        public string GetMessage()
        {
            return string.Format("姓名：{0}，年龄：{1}岁。", this.name, this.age);
        }
    }

    class MyTest
    {
        int a;
        char b;
        string c=null;
        bool d;
        public void show()
        {
            Console.WriteLine("a={0},b={1},c={2},d={3}", a, b, c, d);
        }
    }
}
