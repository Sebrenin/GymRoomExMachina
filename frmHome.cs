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
<<<<<<< Updated upstream

            }

            string query = "INSERT INTO Notes (Content) VALUES (@content)";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {

                cmd.Parameters.AddWithValue("@content", quicknote.Text.Trim());
                con.Open();
                cmd.ExecuteNonQuery();
=======
>>>>>>> Stashed changes

            }



            MessageBox.Show("Nota guardad correctamente.");
            quicknote.Clear();

            var notesForm = Application.OpenForms["frmNotes"] as frmNotes;
            notesForm?.ReloadNotes();
<<<<<<< Updated upstream
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La nota se ha guardado", "Nota registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
=======
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string nota = quicknote.Text.Trim();
            string rutaArchivo = "quick_notes.txt"; // El archivo se guarda en la carpeta donde está el ejecutable

            if (string.IsNullOrWhiteSpace(nota) || nota == "Quick Note...")
            {
                // Si está vacío, solo restablece el placeholder y sale del método.
                quicknote.Text = "Quick Note...";
                quicknote.ForeColor = Color.Gray;
                MessageBox.Show("No hay contenido válido para guardar.", "Advertencia");
                return;
            }

            try
            {
                // Añade la nota al archivo, seguida de un salto de línea (Environment.NewLine)
                // El 'true' en StreamWriter indica que se APPENDERÁ al final, sin borrar lo anterior.
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(rutaArchivo, true))
                {
                    // Opcional: añade la fecha y hora para saber cuándo se escribió la nota
                    file.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}] {nota}");
                }

                MessageBox.Show("Nota guardada correctamente en el archivo.", "Éxito");
                quicknote.Clear();

                // Si frmNotes existe y tiene el método, recarga.
                var notesForm = Application.OpenForms["frmNotes"] as frmNotes;
                notesForm?.ReloadNotes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la nota: {ex.Message}", "Error de Archivo");
            }
        }

        
>>>>>>> Stashed changes
    }
}

