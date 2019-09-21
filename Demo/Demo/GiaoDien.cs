﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Demo
{
    public partial class GiaoDien : Form
    {
        public GiaoDien()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoDienGame uig = new GiaoDienGame();
            uig.Show();
        }
        void Back()
        {
      
        }
        private void GiaoDien_Load(object sender, EventArgs e)
        {
            PlayMusic();
        }

        private void BtnPlayA_Click(object sender, EventArgs e)
        {
          
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        WindowsMediaPlayer sound = new WindowsMediaPlayer() ;

        public void PlayMusic()
        {  
            sound.URL = "coconut_song.wav"; 
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            
                
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            if (sound.enabled)
            {
                sound.controls.pause();
                sound.enabled = !sound.enabled;
            }
            else
            {
                sound.controls.play();
                sound.enabled = !sound.enabled;
            }
        }
    }
}
