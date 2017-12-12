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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
 
        private void btnYes_Click(object sender, EventArgs e)
        {
            
            string userName = txtName.Text;
            string password = txtPwd.Text;
            string connString = ConfigurationManager.AppSettings["DavidConn"];// @"Data Source=.;Initial Catalog=MySchool;Persist Security Info=True;User ID=sa;Password=sql"; 
            SqlConnection conn = new SqlConnection(connString);
            //获取用户名和密码匹配的行的数量的SQL语句
            string sql =String.Format("select count(*) from [User] where UserName='{0}'and password='{1}'",userName,password);
            try
            {
                conn.Open();// 打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);	//创建 Command 对象
                int n = (int)comm.ExecuteScalar();//执行查询语句,返回匹配的行数
                if (n==1)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Tag = true; 
                }
                else
                {
                    MessageBox.Show("您输入的用户名或密码错误！请重试", "登录失败",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Tag = false;  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,  "操作数据库出错！",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Tag = false;
            }
            finally
            {
                conn.Close();	// 关闭数据库连接
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPwd.Text = "";
            txtName.Focus();
        }
    }
}
