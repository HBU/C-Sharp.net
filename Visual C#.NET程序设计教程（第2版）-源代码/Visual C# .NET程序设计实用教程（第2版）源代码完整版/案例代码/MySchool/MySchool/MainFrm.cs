using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MySchool
{
    public partial class MainFrm : Form
    {
        private bool isLogined = false;   //保存登录凭据

        public MainFrm()
        {
            InitializeComponent();
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmNewStudent_Click(object sender, EventArgs e)
        {
            if (isLogined)
            {
                StudentMsgFrm sForm = new StudentMsgFrm();	// 创建子窗体对象
                sForm.MdiParent = this;		//指定当前窗体为MDI父窗体
                sForm.Show();				//打开子窗体
                tssMsg.Text = sForm.Text;		//在状态栏中显示操作内容
            }
            else
                tssMsg.Text = "注意，必须先登录才能使用本系统";
        }

        private void tsmNewCourse_Click(object sender, EventArgs e)
        {
            if (isLogined)
            {
                CourseMsgFrm cForm = new CourseMsgFrm();	// 创建子窗体对象
                cForm.MdiParent = this;			//指定当前窗体为MDI父窗体          
                cForm.Show();					//打开子窗体
                tssMsg.Text = cForm.Text;			//在状态栏中显示操作内容
            }
            else
            {
                tssMsg.Text = "注意，必须先登录才能使用本系统";
            }
        }

        private void tsmAbout_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm(); // 创建子窗体对象
            about.ShowDialog();               //打开子窗体
            tssMsg.Text = about.Text;         //在状态栏中显示操作内容
        }

        private void tsmLogin_Click(object sender, EventArgs e)
        {
            Login lForm = new Login();    //实例化“用户登录”窗体
            tssMsg.Text = lForm.Text;
            //显示“用户登录”窗体并检测用户是否单击过“登录”按钮
            if (lForm.ShowDialog() == DialogResult.OK) 
            {
                if ((bool)lForm.Tag)   //如果登录成功
                {
                    isLogined = true;
                    tssMsg.Text = "恭喜您，已经成功登录系统！";
                }
                else
                {
                    isLogined = false;
                    tssMsg.Text = "注意，必须先登录才能使用本系统";
                }
            }
        }

        private void tsmStuMsgMag_Click(object sender, EventArgs e)
        {
            if (isLogined)
            {
                StudentFrm sForm = new StudentFrm();	// 创建子窗体对象
                sForm.MdiParent = this;		//指定当前窗体为MDI父窗体
                sForm.Show();				//打开子窗体
                tssMsg.Text = sForm.Text;		//在状态栏中显示操作内容
            }
            else
                tssMsg.Text = "注意，必须先登录才能使用本系统";
        }

        private void tsmCurMsgMag_Click(object sender, EventArgs e)
        {
            if (isLogined)
            {
                CourseFrm cForm = new CourseFrm();	// 创建子窗体对象
                cForm.MdiParent = this;		//指定当前窗体为MDI父窗体
                cForm.Show();				//打开子窗体
                tssMsg.Text = cForm.Text;		//在状态栏中显示操作内容
            }
            else
                tssMsg.Text = "注意，必须先登录才能使用本系统";
        }

        private void tsmScoreMsg_Click(object sender, EventArgs e)
        {
            if (isLogined)
            {
                ScoreMsgFrm  sForm = new ScoreMsgFrm();	// 创建子窗体对象
                sForm.MdiParent = this;		//指定当前窗体为MDI父窗体
                sForm.Show();				//打开子窗体
                tssMsg.Text = sForm.Text;		//在状态栏中显示操作内容
            }
            else
                tssMsg.Text = "注意，必须先登录才能使用本系统";
        }
    }
}
