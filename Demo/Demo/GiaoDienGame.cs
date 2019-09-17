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
    public partial class GiaoDienGame : Form
    {
        public GiaoDienGame()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        string[] arr = new string[3];
        
        private void GiaoDienGame_Load(object sender, EventArgs e)
        {
            btnPlayA.Hide();
            arr[0] = "Bạn tên gì?";
            arr[1] = "Bạn ăn cơm chưa?";
            arr[2] = "Bạn bao nhiêu tuổi?";
            lbQuestion.Text = arr[0];

        }

        private void BtnPlayA_Click(object sender, EventArgs e)
        {
            GiaoDien gd = new GiaoDien();
            gd.Show();
            this.Hide();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            lbQuestion.Text = arr[1];
        }
    }
}
