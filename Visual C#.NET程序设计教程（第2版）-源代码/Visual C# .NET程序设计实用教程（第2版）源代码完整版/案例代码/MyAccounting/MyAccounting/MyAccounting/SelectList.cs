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
    public partial class SelectList : Form
    {
        string connString = @"Data Source=.;Initial Catalog=Financing ;User ID=sa;Pwd=123456";
        SqlConnection connection;

      
        public SelectList()
        {
            InitializeComponent();
        }

private void btnSelect_Click(object sender, EventArgs e)
{
    string key = cboKey.SelectedItem.ToString();
    string value1 = txtValue1.Text.Trim();
    string condition = "";
    switch(key)
    {
        case "收支项":
            condition=String.Format("and c.ItemName like '%{0}%'",value1);break;
        case "类别":
            condition=String.Format("and b.CategoryName like '%{0}%'",value1);break;
        case "说明":
            condition=String.Format("and a.Explain like '%{0}%'",value1);break;
        case "金额":
            condition=String.Format("and a.Amount between '{0}' and '{1}'",value1,txtValue2.Text.Trim());break;
        case "日期":
            condition=String.Format("and a.TradeDate between '{0}' and '{1}'",value1,txtValue2.Text.Trim());break;  
        

    }
    string sql = "select a.ListID as ID,c.ItemName as 收支项,b.CategoryName as 类别,b.IsPayout as 是否支出,"
        +"a.TradeDate as 收支日期,a.Amount as 金额,a.Explain as 说明"
        + " from List as a,Category as b,Item as c  where a.ItemID=c.ItemID and c.CategoryID=b.CategoryID  "
        + condition;
    SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
    DataSet dataSet = new DataSet();
    dataAdapter.Fill(dataSet);
    dgvList.DataSource = dataSet.Tables[0];
    ;



            

            
}

        private void cboKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = cboKey.SelectedItem.ToString();
            txtValue1.Text = txtValue2.Text = "";
            if (key == "金额" || key == "日期") txtValue2.Enabled = true;
            else txtValue2.Enabled = false;
            
        }

        private void SelectList_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connString);
            cboKey.SelectedIndex = 0;
            
           
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            string id = dgvList.SelectedRows[0].Cells[0].Value.ToString();
            MessageBox.Show(id);
        }

        private void tsmUpdate_Click(object sender, EventArgs e)
        {
            string id = dgvList.SelectedRows[0].Cells[0].Value.ToString();
            UpdateExpenditure updateFrm = new UpdateExpenditure(id);          // 创建子窗体对象
                            //指定当前窗体为MDI父窗体 
            updateFrm.ShowDialog();                          //打开子窗体
           
        }

       
    }
}
