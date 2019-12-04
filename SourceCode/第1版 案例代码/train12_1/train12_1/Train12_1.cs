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

namespace train11_1
{
    public partial class Train12_1 : Form
    {
        public Train12_1()
        {
            InitializeComponent();
        }
        private StudentList list = new StudentList();   //学生列表对象
        private int current = 0;       //当前学生索引
        private void ShowCurrent()     //显示当前学生的数据
        {
            txtNo.Text = list[current].sno.ToString();
            txtName.Text = list[current].name;
            if (list[current].sex)
                rdoMale.Checked = true;
            else
                rdoFemale.Checked = false;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (current == 0)
            {
                MessageBox.Show("已经是第一条学生！");
            }
            else
            {
                current--;
                ShowCurrent();
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (current == list.Count -1 )
            {
                MessageBox.Show("已经是第一条数据了！");
            }
            else
            {
                current++;
                ShowCurrent();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int sno = Int32.Parse(txtNo.Text);
            bool isMale;
            if (rdoMale.Checked)
                isMale = true;
            else
                isMale = false;
            Student s = new Student(sno, txtName.Text, isMale);
            list[list.Count] = s;            //把学生添加到列表中
            current = list.Count;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = current;
            while (i < list.Count)
            {
                list[i] = list[i + 1];
                i++;
            }
            list[i - 1] = null;
            if (current == list.Count) current--;
            ShowCurrent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFile.ShowDialog();
        }

        private void openFile_FileOk(object sender, CancelEventArgs e)
        {
            Stream stream = openFile.OpenFile();          //打开选中的文件
            BinaryFormatter bf = new BinaryFormatter();   //创建格式化对象
            list = (StudentList)bf.Deserialize(stream);  //把流反序列化
            if (list[0] != null)
            {
                current = 0;
                ShowCurrent();                             //显示当前数据
            }
        }

        private void saveFile_FileOk(object sender, CancelEventArgs e)
        {
            Stream stream = saveFile.OpenFile();
            BinaryFormatter bf = new BinaryFormatter();   //创建序列化对象
            bf.Serialize(stream, list);         //把学生列表序列化并写入流
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
        public int Count
        {
            get
            {
                int i = 0;
                while (list[i] != null)
                    i++;
                return i;
            }
        }
    }

}
