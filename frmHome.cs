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

namespace GymRoom
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
            frmChats frmChats = new frmChats();
            frmChats.Show();
            this.Hide();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void profile_Click(object sender, EventArgs e)
        {
            frmCoachProfile frmCoachProfile = new frmCoachProfile();
            frmCoachProfile.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frmMycostumers frmMycostumers = new frmMycostumers();
            frmMycostumers.Show();
            this.Hide();
        }

        private void gotonotes_Click(object sender, EventArgs e)
        {
            frmNotes frmNotes = new frmNotes();
            frmNotes.Show();
            this.Hide();
        }

        private void btnQuickNoteSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(quicknote.Text))
            {
                quicknote.Text = "Quick Note...";
                quicknote.ForeColor = Color.Gray;
                
            }

            string query = "INSERT INTO Notes (Content) VALUES (@content)";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {

                cmd.Parameters.AddWithValue("@content", quicknote.Text.Trim());
                con.Open();
                cmd.ExecuteNonQuery();

            }

            MessageBox.Show("Nota guardad correctamente.");
            quicknote.Clear();

            var notesForm = Application.OpenForms["frmNotes"] as frmNotes;
            notesForm?.ReloadNotes();
        }       

        }
    }

