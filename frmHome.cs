using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GymRoom;


namespace GymRoomExMachina
{

    public partial class frmHome : Form
    {
        private string connectionString = "Server=localhost;Database=GymRoomDB;Trusted_Connection=True;";
        public frmHome()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //go to profile
        private void profile_Click(object sender, EventArgs e)
        {
            frmCoachProfile frmCoachProfile = new frmCoachProfile();
            frmCoachProfile.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frmMember frmMember = new frmMember();
            frmMember.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmNotes frmNotes = new frmNotes();
            frmNotes.Show();
            this.Hide();
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            frmRoutine frmRoutine = new frmRoutine();
            frmRoutine.Show();
            this.Hide();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            frmMealtable frmMealtable = new frmMealtable();
            frmMealtable.Show();
            this.Hide();
        }
    }
}

