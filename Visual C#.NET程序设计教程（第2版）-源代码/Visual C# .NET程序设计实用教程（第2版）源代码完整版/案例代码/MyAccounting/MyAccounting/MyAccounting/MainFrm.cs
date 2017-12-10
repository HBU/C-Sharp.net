using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyAccounting
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmAddExp_Click(object sender, EventArgs e)
        {
            AddExpenditure AddTxpFrm = new AddExpenditure();	// 创建子窗体对象
            AddTxpFrm.MdiParent = this;						    //指定当前窗体为MDI父窗体 
            AddTxpFrm.Show();								    //打开子窗体
            tssMsg.Text = AddTxpFrm.Text;					    //在状态栏中显示操作内容

        }

        private void tsmAddItems_Click(object sender, EventArgs e)
        {
            AddItems AddItemsFrm = new AddItems();	// 创建子窗体对象
            AddItemsFrm.MdiParent = this;						    //指定当前窗体为MDI父窗体 
            AddItemsFrm.Show();								    //打开子窗体
            tssMsg.Text = AddItemsFrm.Text;					    //在状态栏中显示操作内容

        }

        private void tsmAbout_Click(object sender, EventArgs e)
        {
            About aboutFrm = new About();          // 创建子窗体对象
            aboutFrm.MdiParent = this;                  //指定当前窗体为MDI父窗体 
            aboutFrm.Show();                          //打开子窗体
            tssMsg.Text = aboutFrm.Text;                //在状态栏中显示操作内容

        }

        private void tsmStatistics_Click(object sender, EventArgs e)
        {
            SelectList listFrm = new SelectList();          // 创建子窗体对象
            listFrm.MdiParent = this;                  //指定当前窗体为MDI父窗体 
            listFrm.Show();                          //打开子窗体
            tssMsg.Text = listFrm.Text;                //在状态栏中显示操作内容
        }
    }
}
