namespace GymRoomExMachina
{
    partial class MyChats
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
            splitContainer1 = new SplitContainer();
            gbackpanel = new Panel();
            infopanel = new Panel();
            writemsg = new Panel();
            contactflwy = new FlowLayoutPanel();
            contchat = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(contactflwy);
            splitContainer1.Panel1.Controls.Add(gbackpanel);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(contchat);
            splitContainer1.Panel2.Controls.Add(writemsg);
            splitContainer1.Panel2.Controls.Add(infopanel);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 285;
            splitContainer1.TabIndex = 0;
            // 
            // gbackpanel
            // 
            gbackpanel.Dock = DockStyle.Top;
            gbackpanel.Location = new Point(0, 0);
            gbackpanel.Name = "gbackpanel";
            gbackpanel.Size = new Size(285, 59);
            gbackpanel.TabIndex = 0;
            // 
            // infopanel
            // 
            infopanel.Dock = DockStyle.Top;
            infopanel.Location = new Point(0, 0);
            infopanel.Name = "infopanel";
            infopanel.Size = new Size(511, 92);
            infopanel.TabIndex = 0;
            // 
            // writemsg
            // 
            writemsg.Dock = DockStyle.Bottom;
            writemsg.Location = new Point(0, 382);
            writemsg.Name = "writemsg";
            writemsg.Size = new Size(511, 68);
            writemsg.TabIndex = 1;
            // 
            // contactflwy
            // 
            contactflwy.AutoScroll = true;
            contactflwy.Dock = DockStyle.Fill;
            contactflwy.FlowDirection = FlowDirection.TopDown;
            contactflwy.Location = new Point(0, 59);
            contactflwy.Name = "contactflwy";
            contactflwy.Size = new Size(285, 391);
            contactflwy.TabIndex = 1;
            // 
            // contchat
            // 
            contchat.AutoScroll = true;
            contchat.Dock = DockStyle.Fill;
            contchat.Location = new Point(0, 92);
            contchat.Name = "contchat";
            contchat.Size = new Size(511, 290);
            contchat.TabIndex = 2;
            // 
            // MyChats
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "MyChats";
            Text = "MyChats";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private FlowLayoutPanel contactflwy;
        private Panel gbackpanel;
        private Panel writemsg;
        private Panel infopanel;
        private FlowLayoutPanel contchat;
    }
}