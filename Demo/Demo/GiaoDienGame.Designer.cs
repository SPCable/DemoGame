namespace Demo
{
    partial class GiaoDienGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPlayA = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbQuestion = new System.Windows.Forms.Label();
            this.rdA = new System.Windows.Forms.RadioButton();
            this.rdB = new System.Windows.Forms.RadioButton();
            this.rdC = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 37);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Demo.Properties.Resources.error_1_;
            this.pictureBox1.Location = new System.Drawing.Point(631, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 36);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Demo.Properties.Resources.circle_64;
            this.pictureBox2.Location = new System.Drawing.Point(602, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(619, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "60";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlayA
            // 
            this.btnPlayA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(215)))), ((int)(((byte)(196)))));
            this.btnPlayA.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPlayA.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayA.ForeColor = System.Drawing.Color.Black;
            this.btnPlayA.Location = new System.Drawing.Point(479, 340);
            this.btnPlayA.Name = "btnPlayA";
            this.btnPlayA.Size = new System.Drawing.Size(177, 48);
            this.btnPlayA.TabIndex = 4;
            this.btnPlayA.Text = "Play Again?";
            this.btnPlayA.UseVisualStyleBackColor = false;
            this.btnPlayA.Click += new System.EventHandler(this.BtnPlayA_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(214)))), ((int)(((byte)(141)))));
            this.panel2.Controls.Add(this.lbQuestion);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(95, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 98);
            this.panel2.TabIndex = 5;
            // 
            // lbQuestion
            // 
            this.lbQuestion.AutoSize = true;
            this.lbQuestion.Location = new System.Drawing.Point(168, 25);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(164, 39);
            this.lbQuestion.TabIndex = 0;
            this.lbQuestion.Text = "Question";
            // 
            // rdA
            // 
            this.rdA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdA.Location = new System.Drawing.Point(68, 150);
            this.rdA.Name = "rdA";
            this.rdA.Size = new System.Drawing.Size(197, 55);
            this.rdA.TabIndex = 6;
            this.rdA.TabStop = true;
            this.rdA.Text = "radioButton1";
            this.rdA.UseVisualStyleBackColor = true;
            // 
            // rdB
            // 
            this.rdB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdB.Location = new System.Drawing.Point(68, 211);
            this.rdB.Name = "rdB";
            this.rdB.Size = new System.Drawing.Size(197, 55);
            this.rdB.TabIndex = 6;
            this.rdB.TabStop = true;
            this.rdB.Text = "radioButton1";
            this.rdB.UseVisualStyleBackColor = true;
            // 
            // rdC
            // 
            this.rdC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdC.Location = new System.Drawing.Point(68, 272);
            this.rdC.Name = "rdC";
            this.rdC.Size = new System.Drawing.Size(197, 55);
            this.rdC.TabIndex = 6;
            this.rdC.TabStop = true;
            this.rdC.Text = "radioButton1";
            this.rdC.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNext.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNext.Location = new System.Drawing.Point(247, 340);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(177, 48);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Score: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "0";
            // 
            // GiaoDienGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(214)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(668, 400);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdC);
            this.Controls.Add(this.rdB);
            this.Controls.Add(this.rdA);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPlayA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GiaoDienGame";
            this.Text = "GiaoDienGame";
            this.Load += new System.EventHandler(this.GiaoDienGame_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPlayA;
        private System.Windows.Forms.RadioButton rdC;
        private System.Windows.Forms.RadioButton rdB;
        private System.Windows.Forms.RadioButton rdA;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNext;
    }
}