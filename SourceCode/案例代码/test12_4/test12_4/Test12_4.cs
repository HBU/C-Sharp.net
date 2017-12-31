using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace test11_4
{
    public partial class Test11_4 : Form
    {
        public Test11_4()
        {
            InitializeComponent();
        }

        private StudentList list = new StudentList();    //声明一个学生列表
        private int i = 0;   //i用来标记即将加入列表中的学生，也代表学生的个数

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Stream stream = saveFileDialog1.OpenFile();
            BinaryFormatter bf = new BinaryFormatter();   //创建序列化对象
            bf.Serialize(stream, list);         //把学生列表序列化并写入流
            stream.Close();
            MessageBox.Show("数据已成功保存！\n" + "文件名为：" + saveFileDialog1.FileName, "恭喜");
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)   //显示打开文件对话框
            {
                txtFile.Text = openFileDialog1.FileName;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            lstShow.Items.Clear();
            lstShow.Items.Add("学号\t姓名\t性别");
            Stream stream = openFileDialog1.OpenFile();   //打开选中的文件
            BinaryFormatter bf = new BinaryFormatter();   //创建序列化对象
            StudentList students = (StudentList)bf.Deserialize(stream);  //把流反序列化
            int k = 0;
            while (students[k] != null)                     //逐个显示学生列表中的数据
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
    [Serializable]     //指示学生类是可序列化的类
    public class Student   //学生类
    {
        public int sno;
        public string name;
        public bool sex;
        public Student(int s_no, string name, bool isMale) //构造函数
        {
            this.sno = s_no;
            this.name = name;
            this.sex = isMale;
        }
    }
    [Serializable]   //指示学生列表是可序列化的类
    public class StudentList    //学生列表类
    {
        private Student[] list = new Student[100];
        public Student this[int index]           //索引器
        {
            get
            {
                if (index < 0 || index >= 100)   // 检查索引范围.
                    return list[0];
                else
                    return list[index];
            }
            set
            {
                if (!(index < 0 || index >= 100))
                    list[index] = value;
            }
        }
    }

}
