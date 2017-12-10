using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
namespace Test13_2
{
    public partial class Test13_2 : Form
    {
        public Test13_2()
        {
            InitializeComponent();
        }

        private void btnDownLoad_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            if (dlgSaveFile.ShowDialog() == DialogResult.OK)
            {
                string fileName = dlgSaveFile.FileName;
                client.DownloadFile(txtUri.Text, fileName);
                lblShow.Text = "下载成功！";
            }
        }
    }
}
