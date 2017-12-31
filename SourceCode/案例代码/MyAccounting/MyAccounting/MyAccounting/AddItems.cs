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
    public partial class AddItems : Form
    {
        string connString = @"Data Source=.;Initial Catalog=Financing ;User ID=sa;Pwd=123456";
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader dataReader;
        public AddItems()
        {
            InitializeComponent();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            //如果没有填写收支项目名称，则弹出对话框告知用户
            if (txtName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请填写收支项目名称！", "信息不完整",MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 

            }
            else
                tabControl1.SelectedTab = tabPage2;//进入“确认信息”选项卡
        }

        private void rdotExpenditure_CheckedChanged(object sender, EventArgs e)
        {
            cboCategory.Items.Clear();
            cboCategory.Items.Add("一级大类");
            string sql = "select  * from Category where IsPayout=1";//选择所有的支出项类别
            if (rdoIncome.Checked == true)//选择所有的收入项类别
                sql = "select  * from Category where IsPayout=0";//选择所有的收入项类别

            try
            {
                connection.Open();									// 打开数据库连接  
                command.CommandText = sql;	//设置 Command 对象要执行的SQL语句
                dataReader = command.ExecuteReader();//调用 Command对象的ExecuteReader()，创建 DataReader 对象
                while (dataReader.Read())  //循环读出所有的类别，并添加到类别组合框中
                {
                    int cId = (int)dataReader[0];//通过索引号读取dataReader中的第一列数据（即类别编号)
                    string name = dataReader["CategoryName"].ToString().Trim();//通过列号读取dataReader中的该列数据（即类别名)
                    cboCategory.Items.Add(new Category(cId, name));  //把Category实例加入cboCategory中

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                dataReader.Close();
                connection.Close();								// 关闭数据库连接
            }
            cboCategory.SelectedIndex = 0; //  默认选择第1项       
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (tabControl1.SelectedIndex == 1)
                {
                    if (txtName.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("请填写收支项目名称！", "信息不完整",MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 

                    }
                    else
                    {
                        rtxtMsg.Clear();
                        rtxtMsg.AppendText("要添加的收支项目为：");
                        rtxtMsg.AppendText(txtName.Text);
                        rtxtMsg.AppendText("\n所属类别:"+cboCategory.SelectedItem.ToString());
                        if (rdotExpenditure.Checked == true) rtxtMsg.AppendText("\n是支出类型的项目");
                        else rtxtMsg.AppendText("\n是收入类型的项目");

                    }
                }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            string name=txtName.Text.Trim();
            int isPayout=rdotExpenditure.Checked?1:0;
            int cId = cboCategory.SelectedIndex;
            string sql="";
            if (cId == 0)
            {
                sql = String.Format("INSERT INTO Category(CategoryName,IsPayout)"
                + "VALUES('{0}',{1})", name, isPayout); 	//要添加的是一级类别，查入Category表中
            }
            else
            {
                Category category=cboCategory.SelectedItem as Category;
                if(category!=null) cId=category.CId;
                sql = String.Format("INSERT INTO  Item(ItemName,CategoryID)VALUES('{0}',{1})",name,cId); 	//要添加的是收入项，查入Item表中
            }
            try
            {
                connection.Open();									// 打开数据库连接  
                command.CommandText = sql;	//设置 Command 对象要执行的SQL语句
                int count = command.ExecuteNonQuery();	// 执行更新命令,返回值为更新的行数
                if (count > 0)
                    MessageBox.Show("添加类别/收支项成功", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("添加类别/收支项失败", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
            finally
            {
                connection.Close();								// 关闭数据库连接
            }

        }

        private void AddItems_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connString);
            command = new SqlCommand();//创建 Command 对象
            command.Connection = connection;//设置command使用的Connection对象
            rdoIncome.Checked = true;//默认选定收入项

        }
        private void BindCategory()
        {

        }

    }
    class Category
    {
        public int CId;
        public string CName;
        public Category(int id, string name)
        {
            CId = id;
            CName = name;
        }
        public override string ToString()
        {
            return CName;
           
        }
    }
}
