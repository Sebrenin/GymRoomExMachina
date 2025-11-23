namespace GymRoomExMachina
{
    partial class ucBurbujaMensaje
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            pnlBurbuja = new Panel();
            lblMensaje = new Label();
            pnlBurbuja.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBurbuja
            // 
            pnlBurbuja.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlBurbuja.BackColor = Color.LightGray;
            pnlBurbuja.Controls.Add(lblMensaje);
            pnlBurbuja.Location = new Point(10, 5);
            pnlBurbuja.MaximumSize = new Size(400, 0);
            pnlBurbuja.Name = "pnlBurbuja";
            pnlBurbuja.Padding = new Padding(8);
            pnlBurbuja.Size = new Size(100, 40);
            pnlBurbuja.TabIndex = 0;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Dock = DockStyle.Fill;
            lblMensaje.ForeColor = Color.Black;
            lblMensaje.Location = new Point(8, 8);
            lblMensaje.MaximumSize = new Size(380, 0);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(38, 15);
            lblMensaje.TabIndex = 0;
            lblMensaje.Text = "label1";
            // 
            // ucBurbujaMensaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(pnlBurbuja);
            Name = "ucBurbujaMensaje";
            Size = new Size(550, 50);
            pnlBurbuja.ResumeLayout(false);
            pnlBurbuja.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlBurbuja;
        private System.Windows.Forms.Label lblMensaje;
    }
}
