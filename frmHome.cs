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
            frmMessages messagesForm = new frmMessages();
            messagesForm.Show();
            this.Hide();
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
            frmMycostumers frmMycostumers = new frmMycostumers();
            frmMycostumers.Show();
            this.Hide();
        }
        //notes
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
                return;
            }

            string nota = quicknote.Text.Trim();
            string rutaArchivo = "quick_notes.txt";

            if (nota == "Quick Note...")
            {
                quicknote.Text = "Quick Note...";
                quicknote.ForeColor = Color.Gray;
                MessageBox.Show("No hay contenido válido para guardar.", "Advertencia");
                return;
            }

            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(rutaArchivo, true))
                {
                    file.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}] {nota}");
                }

                MessageBox.Show("Nota guardada correctamente.", "Éxito");
                quicknote.Clear();

                var notesForm = Application.OpenForms["frmNotes"] as frmNotes;
                notesForm?.ReloadNotes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la nota: {ex.Message}", "Error de Archivo");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string nota = quicknote.Text.Trim();
            string rutaArchivo = "quick_notes.txt";

            if (string.IsNullOrWhiteSpace(nota) || nota == "Quick Note...")
            {
                quicknote.Text = "Quick Note...";
                quicknote.ForeColor = Color.Gray;
                MessageBox.Show("No hay contenido válido para guardar.", "Advertencia");
                return;
            }

            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(rutaArchivo, true))
                {
                    file.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}] {nota}");
                }

                MessageBox.Show("Nota guardada correctamente en el archivo.", "Éxito");
                quicknote.Clear();

                var notesForm = Application.OpenForms["frmNotes"] as frmNotes;
                notesForm?.ReloadNotes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la nota: {ex.Message}", "Error de Archivo");
            }
        }

        
    }
}

