namespace GymRoomExMachina
{
    partial class frmNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotes));
            flpNotes = new FlowLayoutPanel();
            panel1 = new Panel();
            label9 = new Label();
            label8 = new Label();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel5 = new Panel();
            deletebtn = new Button();
            buttonSaveNote = new Button();
            wrtNote1 = new GymRoomExMachina.wrtNote();
            flpNotes.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // flpNotes
            // 
            flpNotes.AutoScroll = true;
            flpNotes.Controls.Add(panel1);
            flpNotes.Controls.Add(flowLayoutPanel1);
            flpNotes.Dock = DockStyle.Left;
            flpNotes.FlowDirection = FlowDirection.TopDown;
            flpNotes.Location = new Point(0, 0);
            flpNotes.Name = "flpNotes";
            flpNotes.Size = new Size(306, 404);
            flpNotes.TabIndex = 0;
            flpNotes.WrapContents = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox9);
            panel1.Controls.Add(pictureBox10);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(303, 37);
            panel1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(132, 9);
            label9.Name = "label9";
            label9.Size = new Size(59, 16);
            label9.TabIndex = 22;
            label9.Text = "My notes";
            label9.Click += label8_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(41, 9);
            label8.Name = "label8";
            label8.Size = new Size(59, 16);
            label8.TabIndex = 21;
            label8.Text = "Go back";
            label8.Click += label8_Click_1;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(15, 9);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(20, 20);
            pictureBox9.TabIndex = 19;
            pictureBox9.TabStop = false;
            pictureBox9.Click += label8_Click_1;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(106, 9);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(20, 20);
            pictureBox10.TabIndex = 20;
            pictureBox10.TabStop = false;
            pictureBox10.Click += label8_Click_1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(3, 46);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(288, 346);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(deletebtn);
            panel5.Controls.Add(buttonSaveNote);
            panel5.Controls.Add(wrtNote1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(306, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(485, 404);
            panel5.TabIndex = 1;
            panel5.Paint += panel5_Paint;
            // 
            // deletebtn
            // 
            deletebtn.BackColor = Color.White;
            deletebtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletebtn.Location = new Point(276, 346);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(75, 23);
            deletebtn.TabIndex = 2;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = false;
            deletebtn.Click += deletebtn_Click;
            // 
            // buttonSaveNote
            // 
            buttonSaveNote.BackColor = Color.White;
            buttonSaveNote.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSaveNote.Location = new Point(368, 346);
            buttonSaveNote.Name = "buttonSaveNote";
            buttonSaveNote.Size = new Size(75, 23);
            buttonSaveNote.TabIndex = 1;
            buttonSaveNote.Text = "Save";
            buttonSaveNote.UseVisualStyleBackColor = false;
            buttonSaveNote.Click += buttonSaveNote_Click;
            // 
            // wrtNote1
            // 
            wrtNote1.BackColor = Color.FromArgb(192, 190, 190);
            wrtNote1.CurrentNote = null;
            wrtNote1.Location = new Point(23, 23);
            wrtNote1.Name = "wrtNote1";
            wrtNote1.Size = new Size(435, 358);
            wrtNote1.TabIndex = 0;
            // 
            // frmNotes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 404);
            Controls.Add(panel5);
            Controls.Add(flpNotes);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmNotes";
            Text = "frmNotes";
            Load += frmNotes_Load;
            flpNotes.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpNotes;
        private Panel panel5;
        private Panel panel1;
        private Label label9;
        private Label label8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private FlowLayoutPanel flowLayoutPanel1;
        private GymRoomExMachina.wrtNote wrtNote1;
        private Button buttonSaveNote;
        private Button deletebtn;
    }
}