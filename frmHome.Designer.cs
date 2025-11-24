namespace GymRoomExMachina
{
    partial class frmHome
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            label1 = new Label();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            profile = new PictureBox();
            chats = new PictureBox();
            members = new PictureBox();
            gotonotes = new PictureBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chats).BeginInit();
            ((System.ComponentModel.ISupportInitialize)members).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gotonotes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(61, 50);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(612, 258);
            panel1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(19, 14);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(20, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 190, 190);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(19, 217);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(575, 25);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(542, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
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
            chats.Location = new Point(12, 128);
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
            members.Location = new Point(12, 203);
            members.Name = "members";
            members.Size = new Size(29, 29);
            members.SizeMode = PictureBoxSizeMode.Zoom;
            members.TabIndex = 7;
            members.TabStop = false;
            members.Click += pictureBox6_Click;
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
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(46, 12);
            label3.Name = "label3";
            label3.Size = new Size(59, 16);
            label3.TabIndex = 3;
            label3.Text = "My notes";
            label3.Click += label3_Click;
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
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 269);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(29, 29);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 15);
            label2.Name = "label2";
            label2.Size = new Size(142, 19);
            label2.TabIndex = 10;
            label2.Text = "Recent messages";
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(89, 11, 11);
            ClientSize = new Size(700, 338);
            Controls.Add(pictureBox4);
            Controls.Add(members);
            Controls.Add(chats);
            Controls.Add(profile);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "frmHome";
            Text = "frmHome";
            Load += frmHome_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)profile).EndInit();
            ((System.ComponentModel.ISupportInitialize)chats).EndInit();
            ((System.ComponentModel.ISupportInitialize)members).EndInit();
            ((System.ComponentModel.ISupportInitialize)gotonotes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private PictureBox profile;
        private PictureBox chats;
        private PictureBox members;
        private PictureBox pictureBox1;
        private PictureBox gotonotes;
        private Label label3;
        private PictureBox pictureBox2;
        private Panel panel2;
        private GymRoomExMachina.wrtNote wrtNote1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label2;
    }
}