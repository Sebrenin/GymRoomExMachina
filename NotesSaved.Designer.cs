namespace GymRoomExMachina
{
    partial class NotesSaved
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotesSaved));
            textBox1 = new TextBox();
            DeleteButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)DeleteButton).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(14, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 16);
            textBox1.TabIndex = 0;
            textBox1.Text = "Name";
            // 
            // DeleteButton
            // 
            DeleteButton.Image = (Image)resources.GetObject("DeleteButton.Image");
            DeleteButton.Location = new Point(260, 26);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(25, 32);
            DeleteButton.SizeMode = PictureBoxSizeMode.Zoom;
            DeleteButton.TabIndex = 2;
            DeleteButton.TabStop = false;
            // 
            // NotesSaved
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DeleteButton);
            Controls.Add(textBox1);
            Name = "NotesSaved";
            Size = new Size(303, 70);
            ((System.ComponentModel.ISupportInitialize)DeleteButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private PictureBox DeleteButton;
    }
}
