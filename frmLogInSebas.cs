using GymRoom_Business.Interfaces;
using GymRoom_Data.Repositories;
using GymRoomExMachina_Data.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymRoomExMachina
{
    public partial class frmLogInSebas : Form
    {
        string connectionString = "Server=DESKTOP-2L7OPJ1;Database=GymRoomDatabase;Trusted_Connection=True;";

        public bool ValidarCoach(string usuario, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                SELECT COUNT(*) 
                FROM Coach 
                WHERE logInCoach = @usuario 
                AND passwordCoach = @password
                AND active = 1";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@password", password);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string user = txtCoach.Text.Trim();
            string pass = txtPassword.Text.Trim();

            bool valido = ValidarCoach(user, pass);

            if (valido)
            {
                MessageBox.Show("Inicio de sesión correcto");

                // Aquí abrirías el siguiente formulario:
                // FormPrincipal frm = new FormPrincipal();
                // frm.Show();
                // this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
