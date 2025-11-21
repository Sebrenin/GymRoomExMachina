using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymRoom
{
    public partial class frmMycostumers : Form
    {
        public frmMycostumers()
        {
            InitializeComponent();
        }

        private void frmMycostumers_Load(object sender, EventArgs e)
        {

        }

<<<<<<< Updated upstream
        private void pictureBox12_Click(object sender, EventArgs e)
=======
        private void label8_Click(object sender, EventArgs e)
>>>>>>> Stashed changes
        {
            frmHome frmHome = new frmHome();
            frmHome.Show();
            this.Hide();
        }

<<<<<<< Updated upstream
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            frmHome Home = new frmHome();
            Home.Show();
            this.Close();
=======
        private void panel2_Click(object sender, EventArgs e)
        {
            frmMember frmMember = new frmMember();
            frmMember.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

>>>>>>> Stashed changes
        }
    }
}
