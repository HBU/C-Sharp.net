using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MyAccounting
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

private void btnLogin_Click(object sender, EventArgs e)
{
    //string userName = txtName.Text;
    //string password = txtPwd.Text;
    //if (userName == "admin" && password == "123")
    //{
    //    MessageBox.Show("欢迎进入个人理账系统！", "登录成功", MessageBoxButtons.OK,
    //        MessageBoxIcon.Information);
    //}
    //else
    //{
    //    MessageBox.Show("您输入的用户名或密码错误！", "登录失败",
    //        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    //}
    string userName = txtName.Text.Trim();
    string password = txtPwd.Text.Trim();
    string connString = @"Data Source=.;Initial Catalog=Financing ;User ID=sa;Pwd=123456";
    SqlConnection connection = new SqlConnection(connString);
    //获取用户名和密码匹配的行的数量的SQL语句
    string sql =String.Format("select count(*) from [User] where UserName='{0}' and Password='{1}'",userName,password);
    try
    {
        connection.Open();// 打开数据库连接     
        SqlCommand command = new SqlCommand(sql, connection);	//创建 Command 对象
        int num = (int)command.ExecuteScalar();//执行查询语句,返回匹配的行数
        if (num > 0)
        {
            //如果有匹配的行,则表明用户名和密码正确
            MessageBox.Show("欢迎进入个人理账系统！", "登录成功", MessageBoxButtons.OK, MessageBoxIcon.Information);    MainFrm mainForm = new MainFrm();			// 创建主窗体对象                    
            mainForm.Show();// 显示窗体
            this.Visible = false; // 登录窗体隐藏
        }
        else
        {
            txtPwd.Text = "";
            MessageBox.Show("您输入的用户名或密码错误！", "登录失败",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
    catch (Exception ex)
    {
            MessageBox.Show(ex.Message,  "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);               
    }
    finally
    {
        connection.Close();								// 关闭数据库连接
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
