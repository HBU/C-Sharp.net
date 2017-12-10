using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test11_6
{
    public partial class SetDialog : Form
    {
        public SetDialog()
        {
            InitializeComponent();
        }
        public string docPosistion
        {
            get
            {
                return txtPosition.Text;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPosition.Text = "";
            this.Hide();
        }



        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPosition.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
