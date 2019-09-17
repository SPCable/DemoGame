using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
