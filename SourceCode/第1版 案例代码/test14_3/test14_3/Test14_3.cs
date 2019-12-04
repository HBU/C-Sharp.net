using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace test14_3
{
    public partial class Test14_3 : Form
    {
        Graphics g;
        Font font;
        Color startColor;
        Color endColor;
        public Test14_3()
        {
            InitializeComponent();
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if (dlgFont.ShowDialog() == DialogResult.OK)
            {
                font = dlgFont.Font;
            }
        }

        private void btnStartColor_Click(object sender, EventArgs e)
        {
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                startColor = dlgColor.Color;
            }
        }

        private void btnEndColor_Click(object sender, EventArgs e)
        {
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                endColor = dlgColor.Color;
            }
        }


        private void btnDraw_Click(object sender, EventArgs e)
        {
            pnlShow.Refresh();
        
        }

        private void pnlShow_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            LinearGradientBrush lgBrush = new LinearGradientBrush(pnlShow.ClientRectangle, startColor, endColor, LinearGradientMode.Horizontal);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.FormatFlags = StringFormatFlags.LineLimit;
            g.DrawString(txtSource.Text, font, lgBrush, pnlShow.ClientRectangle,format);
        }
    }
}