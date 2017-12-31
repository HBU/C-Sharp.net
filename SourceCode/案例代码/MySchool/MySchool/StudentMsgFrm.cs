using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace MySchool
{
    public partial class StudentMsgFrm : Form
    {
        public StudentMsgFrm()
        {
            InitializeComponent();
        }

        private void StudentInfoFrm_Load(object sender, EventArgs e)
        {
            rdoMale.Checked = true;
            cboDept.SelectedIndex = 0;
            dtBirthday.MaxDate = DateTime.Now;
            dtBirthday.Value = dtBirthday.MinDate; 
            timeGo.Enabled = true;
        }

        private void cboDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboDept.SelectedIndex)
            {
                case 0:
                    lstSpec.Items.Clear();
                    lstSpec.Items.Add("计算机科学与技术");
                    lstSpec.Items.Add("信息与计算科学");
                    break;
                case 1:
                    lstSpec.Items.Clear();
                    lstSpec.Items.Add("集成电路与集成系统");
                    lstSpec.Items.Add("集成电路设计与集成系统");
                    break;
                case 2:
                    lstSpec.Items.Clear();
                    lstSpec.Items.Add("通信工程");
                    lstSpec.Items.Add("电子信息工程");
                    lstSpec.Items.Add("电磁场与无线技术");
                    lstSpec.Items.Add("机械设计制造与自动化");
                    break;
                case 3:
                    lstSpec.Items.Clear();
                    lstSpec.Items.Add("国际经济与贸易");
                    lstSpec.Items.Add("电子商务");
                    lstSpec.Items.Add("信息管理与信息系统");
                    lstSpec.Items.Add("财务管理");
                    break;
                default:
                    lstSpec.Items.Clear();
                    lstSpec.Items.Add("数字动画");
                    lstSpec.Items.Add("影视动画");
                    lstSpec.Items.Add("数字媒体");
                    lstSpec.Items.Add("平面设计");
                    break;
            }
            lstSpec.SelectedIndex = 0;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            string sex = "";
            if (rdoMale.Checked)
                sex = rdoMale.Text;
            else
                sex = rdoFemale.Text;
            string dept = cboDept.SelectedItem.ToString();
            string spec = lstSpec.SelectedItem.ToString();
            string hobby = "";
            if (checkBox1.Checked) hobby += checkBox1.Text;
            if (checkBox2.Checked) hobby += "、"+ checkBox2.Text;
            if (checkBox3.Checked) hobby += "、" + checkBox3.Text;
            if (checkBox4.Checked) hobby += "、" + checkBox4.Text;
            if (checkBox5.Checked) hobby += "、" + checkBox5.Text;
            if (checkBox6.Checked) hobby += "、" + checkBox6.Text;
            string connString = ConfigurationManager.AppSettings["DavidConn"]; //@"Data Source=.\SQLEXPRESS;Initial Catalog=MySchool;Integrated Security=True";
            string sql = String.Format("INSERT INTO StudentMsg(StudentName,Sex,Birthday,Department,Speciality,Hobby) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')",txtName.Text,sex,dtBirthday.Value,dept,spec,hobby);//SQL语句
            using( SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();	//打开数据库连接 
                SqlCommand comm = new SqlCommand(sql, conn); //创建 Command 对象
                int n = comm.ExecuteNonQuery();	//执行添加命令,返回值为更新的行数
                if (n > 0)
                {
                    MessageBox.Show("添加学生信息成功", "添加成功",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("添加学生信息失败", "添加失败",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timeGo_Tick(object sender, EventArgs e)
        {   //实现滚动显示“天行健，君子以自强不息！”
            if (lblTip.Left >= this.Width)
            {
                lblTip.Left = 0;
            }
            lblTip.Left += 1;
        }
    }
}
