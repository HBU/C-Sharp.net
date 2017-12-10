using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Test13_8
{
    public partial class Test13_8 : Form
    {
        string changeDir;  //更换的目录名
        bool isAnonymous;  //指示是否以匿名方式访问FTP服务器
        FtpHelper helper;  //FTP助手
        public Test13_8()
        {
            InitializeComponent();
            txtFtpUri.Text = "ftp://127.0.0.1";  //设置默认的FTP服务器
            txtPort.Text = "21";                 //设置默认的FTP端口
            changeDir = String.Empty;
            helper = new FtpHelper();
        }
        void ShowFileList(string path)   //显示文件列表
        {
            bool isSucessed = false;
            if (isAnonymous)                //连接FTP服务器
                isSucessed = helper.ConnectionToFtp(path);
            else
                isSucessed = helper.ConnectionToFtp(path, txtName.Text, txtPwd.Text);
            listBox1.DataSource = helper.getFilesList();  //显示FTP服务器中的文件列表
            if (!isSucessed)
            {
                MessageBox.Show("无法连接指定的FTP服务器！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnConnection_Click(object sender, EventArgs e)//点击“连接”按钮
        {

            Cursor currentCursor=this.Cursor;//保存当前鼠标指针显示的光标
            this.Cursor = Cursors.WaitCursor;//指针显示的光标改变为等待光标
            string ftp = txtFtpUri.Text + ":" + txtPort.Text;
            ShowFileList(ftp);                  //显示FTP服务器根目录中的文件
            this.Cursor = currentCursor;//恢复鼠标指针显示的光标
        }

        private void btnDownLoad_Click(object sender, EventArgs e)//点击“下载”按钮
        {
            bool isSucessed = false;
            Cursor currentCursor = this.Cursor;  //保存当前鼠标指针显示的光标
            this.Cursor = Cursors.WaitCursor;    //指针显示的光标改变为等待光标
            string ftp = txtFtpUri.Text + ":" + txtPort.Text;
            string fileName = listBox1.SelectedItem.ToString().Trim(); ;
            string fullName=changeDir+"/"+fileName;   //得到目标文件的虚拟路径
            ftp = ftp + fullName;
            if (isAnonymous)
            {
                helper.ConnectionToFtp(ftp);
            }
            else
            {
                helper.ConnectionToFtp(ftp,txtName.Text,txtPwd.Text);
 
            }
            saveFileDialog1.FileName = fileName;  
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)           //显示“另存为”对话框
            {
                isSucessed= helper.DownLoad(saveFileDialog1.FileName);  //下载并保存文件
            }
            if(isSucessed)
                MessageBox.Show(String.Format("文件{0}\n下载成功！", saveFileDialog1.FileName), "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("文件下载失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Cursor = currentCursor;    //恢复鼠标指针显示的光标   
        }

        private void btnChangDir_Click(object sender, EventArgs e)
        { 
            //显示FTP子目录中的文件列表
            Cursor currentCursor = this.Cursor;
            this.Cursor = Cursors.WaitCursor;
            string subDir = listBox1.SelectedItem.ToString().Trim();  
            changeDir += "/" + subDir;
            string path = txtFtpUri.Text + ":" + txtPort.Text;
            path += changeDir;
            ShowFileList(path);         //显示FTP服务器中的指定子目录中的文件列表
            this.Cursor = currentCursor;//恢复鼠标指针显示的光标
        }

        private void chkAnonymous_Click(object sender, EventArgs e)
        {
            if (chkAnonymous.Checked)  
            {
                grpLogin.Enabled = false;  //如果选择匿名访问，则使用户登录功能失效
                isAnonymous = true;
            }
            else
            {
                grpLogin.Enabled = true;
                isAnonymous = false;
            }
        }

        private void btnFileUp_Click(object sender, EventArgs e)
        {
            bool isSucessed = false;
            Cursor currentCursor = this.Cursor;  //保存当前鼠标指针显示的光标
            this.Cursor = Cursors.WaitCursor;    //指针显示的光标改变为等待光标
            string ftp = txtFtpUri.Text + ":" + txtPort.Text +"/" + changeDir + "/";
            string sourceFile = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)           //显示“另存为”对话框
            {
                sourceFile = openFileDialog1.FileName;         //获得选中的文件名（包括文件路径）
                string fullFtpPath = ftp + sourceFile.Substring(sourceFile.LastIndexOf('\\') + 1);
                if (isAnonymous)
                {
                    helper.ConnectionToFtp(fullFtpPath);
                }
                else
                {
                    helper.ConnectionToFtp(fullFtpPath, txtName.Text, txtPwd.Text);

                }
                isSucessed = helper.FileUp(sourceFile);  //下载并保存文件
            }  
            if (isSucessed)
                MessageBox.Show(String.Format("文件{0}\n上传成功！", sourceFile), "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("文件上传失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ShowFileList(ftp);   
            this.Cursor = currentCursor;    //恢复鼠标指针显示的光标   
        }      
    }


}
