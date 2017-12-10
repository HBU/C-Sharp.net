using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
namespace test12_5
{
    public partial class Test12_9 : Form
    {
        public Test12_9()
        {
            InitializeComponent();
        }
        private XmlDocument doc;
        private XmlElement root;
        private int current = 1 ;
        private void showStudent(int i)
        {
            XmlNodeList a = root.GetElementsByTagName("学生");
            XmlElement student = (XmlElement)a[i];
            txtType.Text = student.Attributes["类别"].Value;
            txtNo.Text = student.Attributes["学号"].Value;
            txtCnName.Text = student.ChildNodes[0].Attributes["中文名"].Value;
            txtEnName.Text = student.ChildNodes[0].Attributes["英文名"].Value;
            txtSex.Text = student.ChildNodes[1].InnerText;
            txtTel.Text = student.ChildNodes[2].InnerText;
        }
        private XmlElement createStudent()
        {
            XmlElement student = doc.CreateElement("学生");   //4. 创建学生元素

            XmlAttribute attr = doc.CreateAttribute("类别");  //5. 创建学生元素的各属性
            attr.Value = txtType.Text;
            student.Attributes.Append(attr);

            attr = doc.CreateAttribute("学号");
            attr.Value = txtNo.Text;
            student.Attributes.Append(attr);

            //6. 创建学生元素的各子元素
            XmlElement elem = doc.CreateElement("姓名");
            attr = doc.CreateAttribute("中文名");
            attr.Value = txtCnName.Text;
            elem.Attributes.Append(attr);
            attr = doc.CreateAttribute("英文名");
            attr.Value = txtEnName.Text;
            elem.Attributes.Append(attr);
            student.AppendChild(elem);

            elem = doc.CreateElement("性别");
            XmlText text = doc.CreateTextNode(txtSex.Text);
            elem.AppendChild(text);
            student.AppendChild(elem);

            elem = doc.CreateElement("电话");
            text = doc.CreateTextNode(txtTel.Text);
            elem.AppendChild(text);
            student.AppendChild(elem);

            return student;
        }

        private void Test12_5_Load(object sender, EventArgs e)
        {
            doc = new XmlDocument();
            doc.Load(@"d:\data\students.xml");
            root = doc.DocumentElement;
            showStudent(0);
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (current > 1)
            {
                current--;
                showStudent(current - 1);
            }
            else
                MessageBox.Show("已经是第一个了");
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (current < root.ChildNodes.Count)
            {
                current++;
                showStudent(current - 1);
            }
            else
                MessageBox.Show("已经是最后一个了");
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
                root.AppendChild(createStudent());
        }

        private void btnModi_Click(object sender, EventArgs e)
        {
            XmlNode newChild = (XmlNode)createStudent();
            root.ReplaceChild(newChild,root.ChildNodes[current - 1]);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            root.RemoveChild(root.ChildNodes[current - 1]);
            showStudent(current - 1);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            doc.Save(@"d:\data\students.xml");
        }
    }
}
