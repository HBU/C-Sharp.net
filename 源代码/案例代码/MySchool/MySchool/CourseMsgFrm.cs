using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MySchool
{
    public partial class CourseMsgFrm : Form
    {
        string courseName;
        string courseClass;
        string required;
        int credit;
        int prelectionCredit;
        int experimentCredit;
        public CourseMsgFrm()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //如果课程名称为空,则弹出消息框告知用户
            if (txtName.Text.Trim().Length == 0)
            {
                MessageBox.Show("输入信息不完整！", "信息不完整", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                tabControl1.SelectedTab = tabPage2; //显示确认信息选项卡
            }

        }

        private void CourseMsgFrm_Load(object sender, EventArgs e)
        {
            cboClass.SelectedIndex = 0;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                if (txtName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("输入信息不完整！", "信息不完整", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tabControl1.SelectedIndex = 0;
                }
                else
                {
                    courseName = txtName.Text;
                    courseClass = cboClass.SelectedItem.ToString();
                    required = rdoRequired.Checked ? "必修" : "选修";
                    credit = (int)nudCredit.Value;
                    prelectionCredit = (int)nudPrelection.Value;
                    experimentCredit = (int)nudExp.Value;
                    string info = String.Format("课程名:{0}\n课程类别:{1}\n课程性质:{2}\n学分:{3}\n理论学时:{4}\n实验学时:{5}", courseName, courseClass,
               required, credit, prelectionCredit, experimentCredit);
                    txtInfo.Text = info;
                }
  
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            int isRequired = rdoRequired.Checked ? 1 :0;
            string connString = @"Data Source=YJ\SQLEXPRESS;Initial Catalog=MySchool;Integrated Security=True";
            string sql = String.Format("INSERT INTO CourseMsg(CourseName, CourseClass, Required,Credit, PrelectionCredit, ExperimentCredit) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", 
        courseName, courseClass, isRequired, credit, prelectionCredit, experimentCredit); 
            using( SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();// 打开数据库连接
                SqlCommand command = new SqlCommand(sql, conn); //创建Command对象
                int n = command.ExecuteNonQuery();//执行更新命令,返回值为更新的行数
                if (n > 0)
                { 
                    MessageBox.Show("添加课程信息成功", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("添加课程信息失败", "添加失败", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txtInfo.Font = fd.Font;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                txtInfo.ForeColor = cd.Color;
            }
        }
    }
}
