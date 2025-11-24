using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymRoomExMachina
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();

            this.Size = new Size(1440, 1024);
            this.StartPosition = FormStartPosition.CenterScreen;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmPrueba_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //falta centrar el welcome to
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }
    }
}
