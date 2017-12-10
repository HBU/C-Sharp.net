using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;

namespace test11_2
{
    public partial class Test12_2 : Form
    {
        public Test12_2()
        {
            InitializeComponent();
        }
        private StudentList list = new StudentList();    //声明一个学生列表
        private int i = 0;   //i用来标记即将加入列表中的学生，也代表学生的个数
        private void btnSave_Click(object sender, EventArgs e)
        {
            //FileStream fs = new FileStream(@"d:\Data\student.dat",
            //                    FileMode.Append, FileAccess.Write);
            //BinaryWriter bw = new BinaryWriter(fs);
            //bw.Write(Int32.Parse(txtNo.Text));
            //bw.Write(txtName.Text);
            //bool isMale;
            //if (rdoMale.Checked)
            //    isMale = true;
            //else
            //    isMale = false;
            //bw.Write(isMale);
            //fs.Close();
            //bw.Close();

            string file = @"d:\data\student.dat";
            Stream stream = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();   //创建序列化对象
            bf.Serialize(stream, list);    //把学生列表序列化并写入流
            stream.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int sno = Int32.Parse(txtNo.Text);
            bool isMale;
            if (rdoMale.Checked)
                isMale = true;
            else
                isMale = false;
            Student student = new Student(sno, txtName.Text, isMale);
            list[i] = student;  //把学生添加到列表中
            i++;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            //lstShow.Items.Clear();
            //lstShow.Items.Add("学号\t姓名\t性别");
            //FileStream fs = new FileStream(@"d:\data\student.dat",
            //                                FileMode.Open, FileAccess.Read);
            //BinaryReader br = new BinaryReader(fs);
            //fs.Position = 0;
            //while (fs.Position != fs.Length)
            //{
            //    int s_no = br.ReadInt32();
            //    string name = br.ReadString();
            //    string sex = "";
            //    if (br.ReadBoolean())
            //        sex = "男";
            //    else
            //        sex = "女";
            //    string result = String.Format("{0}\t{1}\t{2}", s_no, name, sex);
            //    lstShow.Items.Add(result);
            //}
            //br.Close();
            //fs.Close();

            lstShow.Items.Clear();
            lstShow.Items.Add("学号\t姓名\t性别");
            string file = @"d:\data\student.dat";
            Stream stream = new FileStream(file, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();    //创建序列化对象 
            StudentList students = (StudentList)bf.Deserialize(stream); //把流反序列化
            int k = 0;
            while (students[k] != null)         //逐个显示学生数据
            {
                int s_no = students[k].sno;
                string name = students[k].name;
                bool isMale = students[k].sex;
                string sex = "";
                if (isMale)
                    sex = "男";
                else
                    sex = "女";
                string result = String.Format("{0}\t{1}\t{2}", s_no, name, sex);
                lstShow.Items.Add(result);
                k++;
            }
            stream.Close();
        }


    }
    [Serializable] 
    public class Student   //学生类
    {
        public int sno;
        public string name;
        public bool sex;
            
        public Student(int s_no, string name, bool sex) //构造函数
        {
            this.sno = s_no;
            this.name = name;
            this.sex = sex;
        }
    }
    [Serializable]
    public class StudentList    //学生列表类
    {
        private Student[] list = new Student[100];
        public Student this[int index]           //索引器
        {
            get
            {
                if (index < 0 || index >= 100)   // 检查索引范围.
                {
                    return list[0];
                }
                else
                {
                    return list[index];
                }
            }
            set
            {
                if (!(index < 0 || index >= 100))
                {
                    list[index] = value;
                }
            }
        }
    }
}
