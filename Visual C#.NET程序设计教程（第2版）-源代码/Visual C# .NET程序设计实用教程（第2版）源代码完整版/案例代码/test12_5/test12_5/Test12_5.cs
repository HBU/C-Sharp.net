using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace test11_6
{
    public partial class Test12_5 : Form
    {
        public Test12_5()
        {
            InitializeComponent();
        }
        private int wCount =0;
        private string initialPos = "";
        private DocForm doc;
        private void NewFile_Click(object sender, EventArgs e)
        {
            wCount++;
            doc = new DocForm();
            doc.MdiParent  = this;
            doc.Text = "文档" + wCount;
            doc.Show();
        }

        private void OptionMenu_Click(object sender, EventArgs e)
        {
            SetDialog dlg = new SetDialog();
            dlg.ShowDialog();
            initialPos=dlg.docPosistion;
            dlg.Close();
            openFileDialog1.InitialDirectory = initialPos;
            saveFileDialog1.InitialDirectory = initialPos;
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                RichTextBoxStreamType fileType ;
                switch (openFileDialog1.FilterIndex)
                {
                    case 1: fileType = RichTextBoxStreamType.PlainText; break;
                    case 2: fileType = RichTextBoxStreamType.RichText; break;
                    default: fileType = RichTextBoxStreamType.UnicodePlainText; break;
                }
                wCount++;
                doc = new DocForm();
                doc.MdiParent = this;
                doc.Text = openFileDialog1.FileName;   
                doc.Source.LoadFile(openFileDialog1.FileName, fileType);
                doc.Show();
            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                RichTextBoxStreamType fileType;
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1: fileType = RichTextBoxStreamType.PlainText; break;
                    case 2: fileType = RichTextBoxStreamType.RichText; break;
                    default: fileType = RichTextBoxStreamType.UnicodePlainText; break;
                }
                doc.Source.SaveFile(saveFileDialog1.FileName, fileType);
            }

        }

        private void fontMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK && doc !=null)
            {
                doc.Source.SelectionFont= fontDialog1.Font;
            }
        }

        private void colorMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK && doc !=null)
            {
                doc.Source.SelectionColor = colorDialog1.Color;
            }
        }

        private void closeFile_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
