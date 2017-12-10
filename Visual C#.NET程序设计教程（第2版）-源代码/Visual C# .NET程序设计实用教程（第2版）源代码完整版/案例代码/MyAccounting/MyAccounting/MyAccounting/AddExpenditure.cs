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
 
    public partial class AddExpenditure : Form
    {
        string connString = @"Data Source=.;Initial Catalog=Financing ;User ID=sa;Pwd=123456";
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader dataReader;
        public AddExpenditure()
        {
            InitializeComponent();
        }

        private void AddExpenditure_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connString);
            command = new SqlCommand();//创建 Command 对象
            command.Connection = connection;//设置command使用的Connection对象
            rdoIncome.Checked = true;//默认选定收入项
        }

        private void rdotExpenditure_CheckedChanged(object sender, EventArgs e)
        {
            cboCategory.Items.Clear();
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



private void btnSave_Click(object sender, EventArgs e)
{
    //rtxtRemarks.Clear();
    //rtxtRemarks.AppendText("要保存的信息为：\n");
    //rtxtRemarks.AppendText(cboCategory.SelectedItem.ToString());
    //rtxtRemarks.AppendText("-");
    //rtxtRemarks.AppendText(lstItem.SelectedItem.ToString());
    //rtxtRemarks.AppendText("\n日期：");
    //rtxtRemarks.AppendText(dtpDate.Value.ToLongDateString());
    //rtxtRemarks.AppendText("\n说明：");
    //rtxtRemarks.AppendText(txtExplain.Text);
    //rtxtRemarks.AppendText("\n收支人：");
    //if (chkOwn.Checked) rtxtRemarks.AppendText(chkOwn.Text);
    //if (chkFamily.Checked) rtxtRemarks.AppendText("、" + chkFamily.Text);
    //if (chkRelative.Checked) rtxtRemarks.AppendText("、" + chkRelative.Text);
    //if (chkFriend.Checked) rtxtRemarks.AppendText("、" + chkFriend.Text);
    //if (chkColleague.Checked) rtxtRemarks.AppendText("、" + chkColleague.Text);
    //if (chkOther.Checked) rtxtRemarks.AppendText("、" + chkOther.Text);
    //rtxtRemarks.AppendText("\n金额：");
    //rtxtRemarks.AppendText(numAmount.Value.ToString());
    int iId = 0;//选择的类别编号
    Item item = lstItem.SelectedItem as Item;
    if (item != null) iId = item.IId;
    decimal amount=numAmount.Value;
    DateTime date=dtpDate.Value;
    string explain=txtExplain.Text;


    string sql =String.Format("INSERT INTO List(ItemID,Amount,TradeDate,Explain)VALUES({0},{1},'{2}','{3}')", iId, amount,date,explain); 	//要添加的是一级类别，查入Category表中
           
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        lstItem.Items.Clear();
        int cId = 0;//选择的类别编号

        Category category = cboCategory.SelectedItem as Category;
        if (category != null) cId = category.CId;
        string sql = String.Format("select * from Item where CategoryID={0}", cId); 	//选择指定类别编号的收支项
        try
        {
            connection.Open();									// 打开数据库连接  
            command.CommandText = sql;	//设置 Command 对象要执行的SQL语句
            dataReader = command.ExecuteReader();//调用 Command对象的ExecuteReader()，创建 DataReader 对象
            while (dataReader.Read())  //循环读出所有的收支项，并添加到收支项列表框中
            {
                int iId = (int)dataReader[0];//通过索引号读取dataReader中的第一列数据（即收支项编号)
                string name = dataReader["ItemName"].ToString().Trim();//通过列号读取dataReader中的该列数据（即类别名)
                lstItem.Items.Add(new Item(iId, name));  //把Item实例加入lstItem中

            }
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
    class Item
    {
        public int IId;
        public string IName;
        public Item(int id, string name)
        {
            IId = id;
            IName = name;
        }
        public override string ToString()
        {
            return IName;
        }
    }
}
