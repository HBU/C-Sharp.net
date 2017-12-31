using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Test6_4
{
    public partial class Test6_4 : Form
    {
        Person<Studnet> stu = new Person<Studnet>();
        public Test6_4()
        {
            InitializeComponent();           
        }

        private void btnPupil_Click(object sender, EventArgs e)
        {
            stu.Studnets.Add(new Pupil(txtName.Text));
            lblShow.Text += string.Format("\n添加小学生:{0}成功",txtName.Text);
        }

        private void btnUndergraduate_Click(object sender, EventArgs e)
        {
            stu.Studnets.Add(new Undergraduate(txtName.Text));
            lblShow.Text += string.Format("\n添加大学生:{0}成功", txtName.Text);
        }

        private void btnPostgraduate_Click(object sender, EventArgs e)
        {
            stu.Studnets.Add(new Postgraduate(txtName.Text));
            lblShow.Text += string.Format("\n添加研究生:{0}成功", txtName.Text);

        }

        private void btnStudy_Click(object sender, EventArgs e)
        {
            lblShow.Text = stu.StudyTo();
        }

       
    }

    public abstract class Studnet
    {
        protected string name;
        public Studnet(string name)
        {
            this.name = name;
        }
        public abstract string Study();
    }
    public class Undergraduate : Studnet
    {
        public Undergraduate(string name) : base(name) { }
        public override string Study()
        {
            return string.Format("{0}:我是大学生，我在学习专业知识！",name);
        }
    }
    public class Pupil : Studnet
    {
        public Pupil(string name) : base(name) { }
        public override string Study()
        {
            return string.Format("{0}:我是小学生:我在学习基础知识！", name);
        }
    }
    public class Postgraduate : Undergraduate
    {
        public Postgraduate(string name) : base(name) { }
        public override string Study()
        {
            return string.Format("{0}:我是研究生:我在做科学研究！", name);
        }
    }
    public class Person<T> where T : Studnet
    {
        private List<T> stus = new List<T>();
        public List<T> Studnets
        {
            get
            {
                return stus;
            }
        }

        public string StudyTo()
        {
            string msg=string.Empty;
            foreach (T stu in stus)
            {
                msg+="\n"+stu.Study();
            }
            return msg;
        }


     


    }

    //public class Person<T1, T2>
    //{
    //    T1 t1;
    //    T2 t2;
    //    public Person(T1 x, T2 y)
    //    {
    //        t1 = x;
    //        t2 = y;
    //    }
    //    public string ShowMsg()
    //    {
    //        int a = 5,b = 8;
    //        Swap<int>(ref a, ref b);
    //        return string.Format("{0}:{1}", t1, t2);
    //    }
    //    void Swap<T>(ref T t1, ref T t2)
    //    {
    //        T temp;
    //        temp = t1; t1 = t2; t2 = temp;
    //    }
    //}



}
