namespace GymRoom
{
    partial class LogInControl : UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInControl));
            pictureBox4 = new PictureBox();
            userboton = new TextBox();
            pictureBox5 = new PictureBox();
            pwdboton = new TextBox();
            button1 = new Button();
            incorrectUser = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.BackColor = Color.FromArgb(235, 231, 231);
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(260, 20);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(19, 19);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // userboton
            // 
            userboton.Anchor = AnchorStyles.None;
            userboton.BackColor = Color.FromArgb(235, 231, 231);
            userboton.BorderStyle = BorderStyle.None;
            userboton.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userboton.ForeColor = SystemColors.WindowFrame;
            userboton.Location = new Point(14, 19);
            userboton.Name = "userboton";
            userboton.Size = new Size(276, 20);
            userboton.TabIndex = 12;
            userboton.Text = "  User";
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.None;
            pictureBox5.BackColor = Color.FromArgb(235, 231, 231);
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(260, 64);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(19, 19);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            // 
            // pwdboton
            // 
            pwdboton.Anchor = AnchorStyles.None;
            pwdboton.BackColor = Color.FromArgb(235, 231, 231);
            pwdboton.BorderStyle = BorderStyle.None;
            pwdboton.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pwdboton.ForeColor = SystemColors.WindowFrame;
            pwdboton.Location = new Point(14, 63);
            pwdboton.Name = "pwdboton";
            pwdboton.Size = new Size(276, 20);
            pwdboton.TabIndex = 14;
            pwdboton.Text = "  Password";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(89, 11, 11);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(14, 124);
            button1.Name = "button1";
            button1.Size = new Size(276, 31);
            button1.TabIndex = 16;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = false;
            // 
            // incorrectUser
            // 
            incorrectUser.AutoSize = true;
            incorrectUser.Location = new Point(130, 97);
            incorrectUser.Name = "incorrectUser";
            incorrectUser.Size = new Size(32, 15);
            incorrectUser.TabIndex = 17;
            incorrectUser.Text = "Error";
            incorrectUser.Visible = false;
            // 
            // LogInControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(incorrectUser);
            Controls.Add(button1);
            Controls.Add(pictureBox5);
            Controls.Add(pwdboton);
            Controls.Add(pictureBox4);
            Controls.Add(userboton);
            Name = "LogInControl";
            Size = new Size(304, 174);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox4;
        private TextBox userboton;
        private PictureBox pictureBox5;
        private TextBox pwdboton;
        private Button button1;
        private Label incorrectUser;
    }
}
