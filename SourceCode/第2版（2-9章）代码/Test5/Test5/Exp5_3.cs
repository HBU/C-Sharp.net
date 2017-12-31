using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exp5_3
{
    public partial class Exp5_3 : Form
    {
        public Exp5_3()
        {
            InitializeComponent();
        }
        IPlayer iplayer;
        MP3 mp3;
        AVI avi;
        private void Exp5_3_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            mp3 = new MP3();
            iplayer = (IPlayer)mp3;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            avi = new AVI();
            iplayer = (IPlayer)avi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblShow.Text=iplayer.Play();
        }
    }
    interface IPlayer
    {
        string Play();//播放 
        string Stop();//停止
        string Pause();//暂停
        string Pre();//上一首
        string Next();//下一首

    }
    public class MP3 : IPlayer
    {


        public string Play()
        {
            return "正在播放MP3歌曲！";
        }

        public string Stop()
        {
            return "停止播放MP3歌曲！";
        }

        public string Pause()
        {
            return "暂停播放MP3歌曲！";
        }

        public string Pre()
        {
            return "播放上一首MP3歌曲！";
        }
        public string Next()
        {
             return "播放下一首MP3歌曲！";
        }

    }
    public class AVI : IPlayer
    {
        public string Play()
        {
            return "正在播放AVI视频！";
        }

        public string Stop()
        {
            return "停止播放AVI视频！";
        }

        public string Pause()
        {
            return "暂停播放AVI视频！";
        }

        public string Pre()
        {
            return "播放上一个AVI视频！";
        }
        public string Next()
        {
            return "播放下一个AVI视频！";
        }

    }
}
