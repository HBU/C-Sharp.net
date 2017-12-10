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
    public partial class UpdateExpenditure : Form
    {
        string connString = @"Data Source=.;Initial Catalog=Financing ;User ID=sa;Pwd=123456";
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader dataReader;
        SqlDataAdapter dataAdapter;
        string id;
        public UpdateExpenditure(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void UpdateExpenditure_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connString);
            command = new SqlCommand();//创建 Command 对象
            command.Connection = connection;//设置command使用的Connection对象
            rdoIncome.Checked = true;//默认选定收入项
            string sql = "select a.ListID ,c.ItemID,c.ItemName,b.CategoryID,b.CategoryName,b.IsPayout,a.TradeDate,a.Amount,a.Explain"
                + " from List as a,Category as b,Item as c  where a.ItemID=c.ItemID and c.CategoryID=b.CategoryID  and a.ListID=" + id;
            bool isPayout=true;
            int cid=0,iid=0;
            string cName="",iName="";
            
            try
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
                connection.Open();									// 打开数据库连接  
                command.CommandText = sql;	//设置 Command 对象要执行的SQL语句
                dataReader = command.ExecuteReader();//调用 Command对象的ExecuteReader()，创建 DataReader 对象
                if (dataReader.Read())  //读出该id对应的收支明细，并初始化窗体
                {
                    isPayout = Convert.ToBoolean(dataReader["IsPayout"]);
                    cid = (int)dataReader["CategoryID"];
                    iid = (int)dataReader["ItemID"];
                    cName = dataReader["CategoryName"].ToString();
                    iName = dataReader["ItemName"].ToString();                   
                    dtpDate.Value = Convert.ToDateTime(dataReader["TradeDate"]);
                    numAmount.Value = Convert.ToDecimal(dataReader["Amount"]);
                    txtExplain.Text = dataReader["Explain"].ToString();

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
            rdotExpenditure.Checked = isPayout;


            cboCategory.SelectedValue = cid;
            lstItem.SelectedValue = iid;
           
           
        

        }

        private void rdotExpenditure_CheckedChanged(object sender, EventArgs e)
        {
            
            string sql = "select  * from Category where IsPayout=1";//选择所有的支出项类别
            if (rdoIncome.Checked == true)//选择所有的收入项类别
                sql = "select  * from Category where IsPayout=0";//选择所有的收入项类别

            try
            {
               
                dataAdapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                cboCategory.DataSource = ds.Tables[0];
                cboCategory.ValueMember = "CategoryId";
                cboCategory.DisplayMember = "CategoryName";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                
            
            }
            cboCategory.SelectedIndex = 0; //  默认选择第1项 
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            string cId = cboCategory.SelectedValue.ToString();//选择的类别编号

       
            string sql = String.Format("select * from Item where CategoryID={0}", cId); 	//选择指定类别编号的收支项
            try
            {
                dataAdapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                lstItem.DataSource = ds.Tables[0];
                lstItem.ValueMember = "Itemid";
                lstItem.DisplayMember = "ItemName";


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

        private void btnSave_Click(object sender, EventArgs e)
        {
            int iId = 0;//选择的类别编号
            Item item = lstItem.SelectedItem as Item;
            if (item != null) iId = item.IId;
            decimal amount = numAmount.Value;
            DateTime date = dtpDate.Value;
            string explain = txtExplain.Text;


            string sql = String.Format("UPDATE List  SET ItemID={0},Amount ={1},TradeDate='{2}',Explain = '{3}' WHERE ListID=1", iId, amount, date, explain,id); 	//要添加的是一级类别，查入Category表中

            try
            {
                connection.Open();									// 打开数据库连接  
                command.CommandText = sql;	//设置 Command 对象要执行的SQL语句
                int count = command.ExecuteNonQuery();	// 执行更新命令,返回值为更新的行数
                if (count > 0)
                    MessageBox.Show("添加收支明细成功", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("添加收支明细失败", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
