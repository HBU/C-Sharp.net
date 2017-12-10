using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMPLib;
namespace test14_5
{
    public partial class Test14_5 : Form
    {
        public Test14_5()
        {
            InitializeComponent();
            player.windowlessVideo = true;
            player.uiMode = "none";
            player.settings.autoStart = true;
            player.stretchToFit = true;
            player.enableContextMenu = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string file = openFile.FileName;
                lstSongs.Items.Add(file);
                //lstSongs.HorizontalScrollbar 
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int Count = lstSongs.Items.Count;

            player.URL = lstSongs.Items[r.Next(0, Count)].ToString(); 
        }

        private void lstSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = lstSongs.Text;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                player.Ctlcontrols.pause();
                btnContinue.Text = "继续";
            }
            else
            {
                player.Ctlcontrols.play();
                btnContinue.Text = "暂停";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
        }
    }
}
