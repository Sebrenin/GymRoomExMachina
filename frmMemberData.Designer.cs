namespace GymRoomExMachina
{
    partial class frmMemberData
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
            dgvMember = new DataGridView();
            cboMember = new ComboBox();
            cboRoutine = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtGoal = new TextBox();
            cboDiet = new ComboBox();
            lblMember = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClearAll = new Button();
            btnGoBack = new Button();
            panel1 = new Panel();
            picLeftArrow = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMember).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLeftArrow).BeginInit();
            SuspendLayout();
            // 
            // dgvMember
            // 
            dgvMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMember.Location = new Point(146, 249);
            dgvMember.Name = "dgvMember";
            dgvMember.Size = new Size(512, 163);
            dgvMember.TabIndex = 0;
            // 
            // cboMember
            // 
            cboMember.FormattingEnabled = true;
            cboMember.Location = new Point(146, 100);
            cboMember.Name = "cboMember";
            cboMember.Size = new Size(121, 23);
            cboMember.TabIndex = 1;
            // 
            // cboRoutine
            // 
            cboRoutine.FormattingEnabled = true;
            cboRoutine.Location = new Point(146, 195);
            cboRoutine.Name = "cboRoutine";
            cboRoutine.Size = new Size(156, 23);
            cboRoutine.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(502, 168);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 3;
            label1.Text = "Goal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(331, 168);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 4;
            label2.Text = "Diet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 168);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 5;
            label3.Text = "Routine";
            // 
            // txtGoal
            // 
            txtGoal.Location = new Point(502, 195);
            txtGoal.Name = "txtGoal";
            txtGoal.Size = new Size(156, 23);
            txtGoal.TabIndex = 7;
            // 
            // cboDiet
            // 
            cboDiet.FormattingEnabled = true;
            cboDiet.Location = new Point(331, 195);
            cboDiet.Name = "cboDiet";
            cboDiet.Size = new Size(146, 23);
            cboDiet.TabIndex = 8;
            // 
            // lblMember
            // 
            lblMember.AutoSize = true;
            lblMember.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMember.ForeColor = Color.White;
            lblMember.Location = new Point(284, 15);
            lblMember.Name = "lblMember";
            lblMember.Size = new Size(232, 25);
            lblMember.TabIndex = 9;
            lblMember.Text = "Select the desired option";
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(675, 249);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(675, 278);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(675, 307);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            btnClearAll.FlatStyle = FlatStyle.Flat;
            btnClearAll.Location = new Point(675, 336);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(75, 23);
            btnClearAll.TabIndex = 13;
            btnClearAll.Text = "Clear all";
            btnClearAll.UseVisualStyleBackColor = true;
            // 
            // btnGoBack
            // 
            btnGoBack.FlatStyle = FlatStyle.Flat;
            btnGoBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGoBack.ForeColor = Color.White;
            btnGoBack.Location = new Point(13, 3);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(86, 23);
            btnGoBack.TabIndex = 14;
            btnGoBack.Text = "Go back";
            btnGoBack.TextAlign = ContentAlignment.MiddleRight;
            btnGoBack.UseVisualStyleBackColor = true;
            btnGoBack.MouseEnter += btnGoBack_MouseEnter;
            btnGoBack.MouseLeave += btnGoBack_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Controls.Add(picLeftArrow);
            panel1.Controls.Add(btnGoBack);
            panel1.Controls.Add(lblMember);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 55);
            panel1.TabIndex = 16;
            // 
            // picLeftArrow
            // 
            picLeftArrow.BackgroundImage = Properties.Resources.left_arrow_white;
            picLeftArrow.BackgroundImageLayout = ImageLayout.Zoom;
            picLeftArrow.Location = new Point(4, 3);
            picLeftArrow.Name = "picLeftArrow";
            picLeftArrow.Size = new Size(32, 23);
            picLeftArrow.TabIndex = 16;
            picLeftArrow.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(146, 82);
            label4.Name = "label4";
            label4.Size = new Size(113, 15);
            label4.TabIndex = 17;
            label4.Text = "Select your member";
            // 
            // frmMemberData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(btnClearAll);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cboDiet);
            Controls.Add(txtGoal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboRoutine);
            Controls.Add(cboMember);
            Controls.Add(dgvMember);
            Name = "frmMemberData";
            Text = "Select the desired option";
            Load += frmMemberData_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMember).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLeftArrow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMember;
        private ComboBox cboMember;
        private ComboBox comboBox1;
        private ComboBox cboRoutine;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDiet;
        private TextBox txtGoal;
        private ComboBox cboDiet;
        private Label lblMember;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClearAll;
        private Button btnGoBack;
        private Panel panel1;
        private PictureBox picLeftArrow;
        private Label label4;
    }
}