namespace GymRoom
{
    partial class frmChats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChats));
            splitContainer1 = new SplitContainer();
<<<<<<< Updated upstream
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            btnGoBack = new Button();
            chats = new PictureBox();
            label3 = new Label();
            pictureBox15 = new PictureBox();
            pictureBox14 = new PictureBox();
            textBox1 = new TextBox();
            pictureBox7 = new PictureBox();
            panel3 = new Panel();
            pictureBox12 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel4 = new Panel();
            pictureBox10 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel5 = new Panel();
            pictureBox11 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            pictureBox9 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel6 = new Panel();
            textBox2 = new TextBox();
            pictureBox17 = new PictureBox();
            pictureBox16 = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
=======
            panel2 = new Panel();
            label9 = new Label();
            label8 = new Label();
            pictureBox10 = new PictureBox();
            pictureBox9 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
>>>>>>> Stashed changes
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
<<<<<<< Updated upstream
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chats).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
=======
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
>>>>>>> Stashed changes
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.ControlLight;
            splitContainer1.Panel2.Controls.Add(panel6);
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Size = new Size(801, 451);
            splitContainer1.SplitterDistance = 320;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
<<<<<<< Updated upstream
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(groupBox1);
=======
            // panel2
            // 
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(pictureBox10);
            panel2.Controls.Add(pictureBox9);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 34);
            panel2.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(136, 9);
            label9.Name = "label9";
            label9.Size = new Size(39, 16);
            label9.TabIndex = 26;
            label9.Text = "Chats";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(45, 9);
            label8.Name = "label8";
            label8.Size = new Size(59, 16);
            label8.TabIndex = 25;
            label8.Text = "Go back";
            label8.Click += label8_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(110, 9);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(20, 20);
            pictureBox10.TabIndex = 24;
            pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(19, 9);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(20, 20);
            pictureBox9.TabIndex = 23;
            pictureBox9.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
>>>>>>> Stashed changes
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(320, 451);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
<<<<<<< Updated upstream
            // groupBox1
            // 
            groupBox1.BackColor = Color.Maroon;
            groupBox1.Controls.Add(btnGoBack);
            groupBox1.Controls.Add(chats);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(pictureBox15);
            groupBox1.Controls.Add(pictureBox14);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(pictureBox7);
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(panel4);
            groupBox1.Controls.Add(panel5);
            groupBox1.Controls.Add(panel1);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 445);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // btnGoBack
            // 
            btnGoBack.BackColor = Color.Maroon;
            btnGoBack.BackgroundImageLayout = ImageLayout.Center;
            btnGoBack.FlatAppearance.BorderColor = Color.Maroon;
            btnGoBack.FlatStyle = FlatStyle.Flat;
            btnGoBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGoBack.ForeColor = Color.White;
            btnGoBack.Image = (Image)resources.GetObject("btnGoBack.Image");
            btnGoBack.ImageAlign = ContentAlignment.BottomLeft;
            btnGoBack.Location = new Point(0, 13);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(114, 41);
            btnGoBack.TabIndex = 5;
            btnGoBack.Text = "Go Back";
            btnGoBack.TextAlign = ContentAlignment.MiddleRight;
            btnGoBack.UseVisualStyleBackColor = false;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // chats
            // 
            chats.Image = (Image)resources.GetObject("chats.Image");
            chats.Location = new Point(126, 15);
            chats.Margin = new Padding(3, 4, 3, 4);
            chats.Name = "chats";
            chats.Size = new Size(33, 39);
            chats.SizeMode = PictureBoxSizeMode.Zoom;
            chats.TabIndex = 7;
            chats.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(165, 25);
            label3.Name = "label3";
            label3.Size = new Size(49, 18);
            label3.TabIndex = 8;
            label3.Text = "Chats";
            label3.Click += label3_Click;
            // 
            // pictureBox15
            // 
            pictureBox15.Image = (Image)resources.GetObject("pictureBox15.Image");
            pictureBox15.Location = new Point(204, 56);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(18, 27);
            pictureBox15.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox15.TabIndex = 8;
            pictureBox15.TabStop = false;
            pictureBox15.Click += pictureBox15_Click;
            // 
            // pictureBox14
            // 
            pictureBox14.Image = (Image)resources.GetObject("pictureBox14.Image");
            pictureBox14.Location = new Point(275, 54);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(33, 38);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 7;
            pictureBox14.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(9, 56);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search...";
            textBox1.Size = new Size(189, 27);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(236, 54);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(33, 38);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 6;
            pictureBox7.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(pictureBox12);
            panel3.Controls.Add(pictureBox4);
            panel3.Location = new Point(6, 360);
            panel3.Name = "panel3";
            panel3.Size = new Size(302, 79);
            panel3.TabIndex = 0;
            panel3.Paint += panel3_Paint;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(260, 25);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(30, 30);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 6;
            pictureBox12.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(13, 17);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLight;
            panel4.Controls.Add(pictureBox10);
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(6, 186);
            panel4.Name = "panel4";
            panel4.Size = new Size(302, 81);
            panel4.TabIndex = 0;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(260, 26);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(30, 30);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 6;
            pictureBox10.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(13, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLight;
            panel5.Controls.Add(pictureBox11);
            panel5.Controls.Add(pictureBox3);
            panel5.Location = new Point(6, 273);
            panel5.Name = "panel5";
            panel5.Size = new Size(302, 81);
            panel5.TabIndex = 0;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(260, 15);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(30, 30);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 6;
            pictureBox11.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(13, 15);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(pictureBox9);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(6, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(302, 82);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(260, 26);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(30, 30);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 6;
            pictureBox9.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlDark;
            panel6.Controls.Add(textBox2);
            panel6.Controls.Add(pictureBox17);
            panel6.Controls.Add(pictureBox16);
            panel6.Controls.Add(label2);
            panel6.Location = new Point(3, 397);
            panel6.Name = "panel6";
            panel6.Size = new Size(469, 51);
            panel6.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ControlDark;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(58, 15);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Write a message...";
            textBox2.Size = new Size(363, 20);
            textBox2.TabIndex = 5;
            // 
            // pictureBox17
            // 
            pictureBox17.Image = (Image)resources.GetObject("pictureBox17.Image");
            pictureBox17.Location = new Point(21, 9);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new Size(28, 33);
            pictureBox17.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox17.TabIndex = 6;
            pictureBox17.TabStop = false;
            // 
            // pictureBox16
            // 
            pictureBox16.Image = (Image)resources.GetObject("pictureBox16.Image");
            pictureBox16.Location = new Point(427, 9);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(33, 36);
            pictureBox16.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox16.TabIndex = 6;
            pictureBox16.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 15);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Maroon;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox6);
            panel2.Location = new Point(3, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(472, 57);
            panel2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(206, 20);
            label4.Name = "label4";
            label4.Size = new Size(52, 18);
            label4.TabIndex = 9;
            label4.Text = "NAME";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(50, 50);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(427, 8);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(33, 38);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
=======
>>>>>>> Stashed changes
            // frmChats
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 451);
            Controls.Add(splitContainer1);
            Name = "frmChats";
            Text = "frmChats";
            Load += frmChats_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
<<<<<<< Updated upstream
            flowLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chats).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
=======
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
>>>>>>> Stashed changes
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private FlowLayoutPanel flowLayoutPanel1;
<<<<<<< Updated upstream
        private UserControlChats userControlChats1;
        private UserControlChats userControlChats2;
        private UserControlChats userControlChats3;
        private UserControlChats userControlChats4;
        private Panel panel1;
        private GroupBox groupBox1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel2;
        private Panel panel6;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox12;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox9;
        private PictureBox pictureBox14;
        private PictureBox pictureBox16;
        private PictureBox pictureBox15;
        private TextBox textBox1;
        private PictureBox pictureBox17;
        private PictureBox pictureBox18;
        private Label label8;
        private Label label3;
        private PictureBox chats;
        private Label label4;
        private TextBox textBox2;
        private Button btnGoBack;
=======
        private Panel panel2;
        private Label label9;
        private Label label8;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
>>>>>>> Stashed changes
    }
}