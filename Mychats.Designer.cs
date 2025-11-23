using GymRoom;

namespace GymRoomExMachina
{
    partial class Mychats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mychats));
            splitContainer1 = new SplitContainer();
            pnlContactsContainer = new FlowLayoutPanel();
            chatControl1 = new ChatControl();
            chatControl2 = new ChatControl();
            chatControl3 = new ChatControl();
            chatControl4 = new ChatControl();
            chatControl5 = new ChatControl();
            panel1 = new Panel();
            label9 = new Label();
            label8 = new Label();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pnlChatContainer = new FlowLayoutPanel();
            pnlInput = new Panel();
            pnlHeader = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtmensaje = new TextBox();
            btnenviar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            pnlContactsContainer.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            pnlInput.SuspendLayout();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnenviar).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pnlContactsContainer);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.ControlLight;
            splitContainer1.Panel2.Controls.Add(pnlChatContainer);
            splitContainer1.Panel2.Controls.Add(pnlInput);
            splitContainer1.Panel2.Controls.Add(pnlHeader);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 246;
            splitContainer1.TabIndex = 0;
            // 
            // pnlContactsContainer
            // 
            pnlContactsContainer.AutoScroll = true;
            pnlContactsContainer.Controls.Add(chatControl1);
            pnlContactsContainer.Controls.Add(chatControl2);
            pnlContactsContainer.Controls.Add(chatControl3);
            pnlContactsContainer.Controls.Add(chatControl4);
            pnlContactsContainer.Controls.Add(chatControl5);
            pnlContactsContainer.FlowDirection = FlowDirection.TopDown;
            pnlContactsContainer.Location = new Point(3, 39);
            pnlContactsContainer.Name = "pnlContactsContainer";
            pnlContactsContainer.Size = new Size(241, 408);
            pnlContactsContainer.TabIndex = 1;
            pnlContactsContainer.WrapContents = false;
            // 
            // chatControl1
            // 
            chatControl1.Location = new Point(3, 3);
            chatControl1.Name = "chatControl1";
            chatControl1.Size = new Size(234, 66);
            chatControl1.TabIndex = 0;
            // 
            // chatControl2
            // 
            chatControl2.Location = new Point(3, 75);
            chatControl2.Name = "chatControl2";
            chatControl2.Size = new Size(240, 68);
            chatControl2.TabIndex = 1;
            // 
            // chatControl3
            // 
            chatControl3.Location = new Point(3, 149);
            chatControl3.Name = "chatControl3";
            chatControl3.Size = new Size(240, 68);
            chatControl3.TabIndex = 2;
            // 
            // chatControl4
            // 
            chatControl4.Location = new Point(3, 223);
            chatControl4.Name = "chatControl4";
            chatControl4.Size = new Size(240, 68);
            chatControl4.TabIndex = 3;
            // 
            // chatControl5
            // 
            chatControl5.Location = new Point(3, 297);
            chatControl5.Name = "chatControl5";
            chatControl5.Size = new Size(240, 68);
            chatControl5.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox9);
            panel1.Controls.Add(pictureBox10);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 33);
            panel1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(132, 6);
            label9.Name = "label9";
            label9.Size = new Size(59, 16);
            label9.TabIndex = 22;
            label9.Text = "My chats";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(41, 6);
            label8.Name = "label8";
            label8.Size = new Size(59, 16);
            label8.TabIndex = 21;
            label8.Text = "Go back";
            label8.Click += label8_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(15, 5);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(20, 20);
            pictureBox9.TabIndex = 19;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(106, 5);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(20, 20);
            pictureBox10.TabIndex = 20;
            pictureBox10.TabStop = false;
            // 
            // pnlChatContainer
            // 
            pnlChatContainer.AutoScroll = true;
            pnlChatContainer.Dock = DockStyle.Fill;
            pnlChatContainer.FlowDirection = FlowDirection.TopDown;
            pnlChatContainer.Location = new Point(0, 69);
            pnlChatContainer.Name = "pnlChatContainer";
            pnlChatContainer.Size = new Size(550, 313);
            pnlChatContainer.TabIndex = 2;
            pnlChatContainer.WrapContents = false;
            // 
            // pnlInput
            // 
            pnlInput.BackColor = SystemColors.ActiveBorder;
            pnlInput.Controls.Add(btnenviar);
            pnlInput.Controls.Add(txtmensaje);
            pnlInput.Dock = DockStyle.Bottom;
            pnlInput.Location = new Point(0, 382);
            pnlInput.Name = "pnlInput";
            pnlInput.Size = new Size(550, 68);
            pnlInput.TabIndex = 1;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(89, 11, 11);
            pnlHeader.Controls.Add(pictureBox2);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Controls.Add(pictureBox1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(550, 69);
            pnlHeader.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(507, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(80, 28);
            label1.Name = "label1";
            label1.Size = new Size(71, 16);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtmensaje
            // 
            txtmensaje.BackColor = SystemColors.ControlLight;
            txtmensaje.BorderStyle = BorderStyle.None;
            txtmensaje.Location = new Point(22, 22);
            txtmensaje.Name = "txtmensaje";
            txtmensaje.Size = new Size(478, 16);
            txtmensaje.TabIndex = 0;
            // 
            // btnenviar
            // 
            btnenviar.Image = (Image)resources.GetObject("btnenviar.Image");
            btnenviar.Location = new Point(519, 22);
            btnenviar.Name = "btnenviar";
            btnenviar.Size = new Size(19, 16);
            btnenviar.SizeMode = PictureBoxSizeMode.Zoom;
            btnenviar.TabIndex = 1;
            btnenviar.TabStop = false;
            // 
            // Mychats
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Mychats";
            Text = "Mychats";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            pnlContactsContainer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            pnlInput.ResumeLayout(false);
            pnlInput.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnenviar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        private Label label9;
        private Label label8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private Panel pnlInput;
        private Panel pnlHeader;
        private FlowLayoutPanel pnlChatContainer;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox1;
        private FlowLayoutPanel pnlContactsContainer;
        private ChatControl chatControl1;
        private ChatControl chatControl2;
        private ChatControl chatControl3;
        private ChatControl chatControl4;
        private ChatControl chatControl5;
        private PictureBox btnenviar;
        private TextBox txtmensaje;
    }
}