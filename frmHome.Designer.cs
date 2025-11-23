namespace GymRoom
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            label1 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            quicknote = new RichTextBox();
            gotonotes = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            profile = new PictureBox();
            chats = new PictureBox();
            members = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            pictureBox10 = new PictureBox();
            pictureBox9 = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gotonotes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chats).BeginInit();
            ((System.ComponentModel.ISupportInitialize)members).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(340, 12);
            label1.Name = "label1";
            label1.Size = new Size(56, 19);
            label1.TabIndex = 0;
            label1.Text = "Home";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(217, 217, 217);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox9);
            panel1.Controls.Add(pictureBox10);
            panel1.Location = new Point(61, 50);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(612, 129);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 190, 190);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(19, 91);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(581, 25);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(558, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 14);
            label2.Name = "label2";
            label2.Size = new Size(135, 16);
            label2.TabIndex = 0;
            label2.Text = "Your recent messages";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(217, 217, 217);
            panel2.Controls.Add(quicknote);
            panel2.Controls.Add(gotonotes);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(61, 203);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(612, 115);
            panel2.TabIndex = 2;
            // 
            // quicknote
            // 
            quicknote.BorderStyle = BorderStyle.None;
            quicknote.Location = new Point(15, 37);
            quicknote.Name = "quicknote";
            quicknote.Size = new Size(585, 68);
            quicknote.TabIndex = 0;
            quicknote.Text = "";
            // 
            // gotonotes
            // 
            gotonotes.Image = (Image)resources.GetObject("gotonotes.Image");
            gotonotes.Location = new Point(15, 8);
            gotonotes.Name = "gotonotes";
            gotonotes.Size = new Size(25, 22);
            gotonotes.SizeMode = PictureBoxSizeMode.Zoom;
            gotonotes.TabIndex = 5;
            gotonotes.TabStop = false;
            gotonotes.Click += gotonotes_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(577, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(59, 14);
            label3.Name = "label3";
            label3.Size = new Size(59, 16);
            label3.TabIndex = 3;
            label3.Text = "My notes";
            label3.Click += label3_Click;
            // 
            // profile
            // 
            profile.Image = (Image)resources.GetObject("profile.Image");
            profile.Location = new Point(12, 64);
            profile.Name = "profile";
            profile.Size = new Size(29, 29);
            profile.SizeMode = PictureBoxSizeMode.Zoom;
            profile.TabIndex = 5;
            profile.TabStop = false;
            profile.Click += profile_Click;
            // 
            // chats
            // 
            chats.Image = (Image)resources.GetObject("chats.Image");
            chats.Location = new Point(12, 173);
            chats.Name = "chats";
            chats.Size = new Size(29, 29);
            chats.SizeMode = PictureBoxSizeMode.Zoom;
            chats.TabIndex = 6;
            chats.TabStop = false;
            chats.Click += pictureBox5_Click;
            // 
            // members
            // 
            members.Image = (Image)resources.GetObject("members.Image");
            members.Location = new Point(12, 279);
            members.Name = "members";
            members.Size = new Size(29, 29);
            members.SizeMode = PictureBoxSizeMode.Zoom;
            members.TabIndex = 7;
            members.TabStop = false;
            members.Click += pictureBox6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(58, 77);
            label7.Name = "label7";
            label7.Size = new Size(116, 12);
            label7.TabIndex = 20;
            label7.Text = "I want to change my diet";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(58, 64);
            label8.Name = "label8";
            label8.Size = new Size(38, 12);
            label8.TabIndex = 19;
            label8.Text = "Ryan G";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(59, 43);
            label6.Name = "label6";
            label6.Size = new Size(58, 12);
            label6.TabIndex = 18;
            label6.Text = "I'll arrive late";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(59, 30);
            label5.Name = "label5";
            label5.Size = new Size(48, 12);
            label5.TabIndex = 17;
            label5.Text = "John Doe";
            // 
            // pictureBox10
            // 
            pictureBox10.BackgroundImage = (Image)resources.GetObject("pictureBox10.BackgroundImage");
            pictureBox10.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox10.Location = new Point(30, 67);
            pictureBox10.Margin = new Padding(3, 2, 3, 2);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(23, 22);
            pictureBox10.TabIndex = 16;
            pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackgroundImage = (Image)resources.GetObject("pictureBox9.BackgroundImage");
            pictureBox9.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox9.Location = new Point(30, 31);
            pictureBox9.Margin = new Padding(3, 2, 3, 2);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(23, 22);
            pictureBox9.TabIndex = 15;
            pictureBox9.TabStop = false;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(89, 11, 11);
            ClientSize = new Size(700, 338);
            Controls.Add(members);
            Controls.Add(chats);
            Controls.Add(profile);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmHome";
            Text = "frmHome";
            Load += frmHome_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gotonotes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)profile).EndInit();
            ((System.ComponentModel.ISupportInitialize)chats).EndInit();
            ((System.ComponentModel.ISupportInitialize)members).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private PictureBox gotonotes;
        private PictureBox pictureBox2;
        private PictureBox profile;
        private PictureBox chats;
        private PictureBox members;
        private PictureBox pictureBox1;
        private RichTextBox quicknote;
        private Label label7;
        private Label label8;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
    }
}