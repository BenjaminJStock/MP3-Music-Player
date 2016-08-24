using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MP3_Player
{
    public partial class Form1 : Form
    {
        MusicPlayer player = new MusicPlayer();

        public Form1()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            label1.Text = openFileDialog1.FileName;
            player.open(openFileDialog1.FileName);
        }

        private void Play_Click(object sender, EventArgs e)
        {
            player.play();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            player.stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
