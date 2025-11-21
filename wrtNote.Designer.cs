namespace GymRoomExMachina
{
    partial class wrtNote
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
            contenidonote = new RichTextBox();
            titulonote = new TextBox();
            SuspendLayout();
            // 
            // contenidonote
            // 
            contenidonote.BackColor = Color.FromArgb(192, 190, 190);
            contenidonote.BorderStyle = BorderStyle.None;
            contenidonote.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contenidonote.Location = new Point(16, 64);
            contenidonote.Name = "contenidonote";
            contenidonote.Size = new Size(400, 249);
            contenidonote.TabIndex = 0;
            contenidonote.Text = "";
            // 
            // titulonote
            // 
            titulonote.BackColor = Color.FromArgb(192, 190, 190);
            titulonote.BorderStyle = BorderStyle.None;
            titulonote.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titulonote.Location = new Point(16, 21);
            titulonote.Name = "titulonote";
            titulonote.Size = new Size(400, 20);
            titulonote.TabIndex = 3;
            titulonote.Text = "Tittle";
            // 
            // wrtNote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 190, 190);
            Controls.Add(titulonote);
            Controls.Add(contenidonote);
            Name = "wrtNote";
            Size = new Size(435, 358);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox contenidonote;
        private TextBox titulonote;
    }
}
