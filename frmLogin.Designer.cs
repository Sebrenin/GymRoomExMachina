namespace GymRoom
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            userboton = new TextBox();
            pwdboton = new TextBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(307, 320);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(434, 75);
            label1.Name = "label1";
            label1.Size = new Size(165, 21);
            label1.TabIndex = 1;
            label1.Text = "It's good to see you";
            // 
            // userboton
            // 
            userboton.Anchor = AnchorStyles.None;
            userboton.BackColor = Color.FromArgb(235, 231, 231);
            userboton.BorderStyle = BorderStyle.None;
            userboton.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userboton.ForeColor = SystemColors.WindowFrame;
            userboton.Location = new Point(373, 146);
            userboton.Name = "userboton";
            userboton.Size = new Size(276, 20);
            userboton.TabIndex = 3;
            userboton.Text = "  User";
            // 
            // pwdboton
            // 
            pwdboton.Anchor = AnchorStyles.None;
            pwdboton.BackColor = Color.FromArgb(235, 231, 231);
            pwdboton.BorderStyle = BorderStyle.None;
            pwdboton.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pwdboton.ForeColor = SystemColors.WindowFrame;
            pwdboton.Location = new Point(373, 194);
            pwdboton.Name = "pwdboton";
            pwdboton.Size = new Size(276, 20);
            pwdboton.TabIndex = 4;
            pwdboton.Text = "  Password";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(334, 9);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(17, 17);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(357, 10);
            label2.Name = "label2";
            label2.Size = new Size(59, 16);
            label2.TabIndex = 9;
            label2.Text = "Go back";
            label2.Click += label2_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.BackColor = Color.FromArgb(235, 231, 231);
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(619, 147);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(19, 19);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.None;
            pictureBox5.BackColor = Color.FromArgb(235, 231, 231);
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(619, 195);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(19, 19);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(89, 11, 11);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(373, 250);
            button1.Name = "button1";
            button1.Size = new Size(276, 31);
            button1.TabIndex = 13;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnLogin_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(button1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pwdboton);
            Controls.Add(userboton);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmLogin";
            Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox userboton;
        private TextBox pwdboton;
        private PictureBox pictureBox2;
        private Label label2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button button1;
    }
}
