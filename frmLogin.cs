using GymRoom;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            this.Size = new Size(1440, 1024);
            this.StartPosition = FormStartPosition.CenterScreen;

        }


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


        private void btnLogin_Click(object sender, EventArgs e)
        {
            {

                {
                    string user = userboton.Text.Trim();
                    string pass = pwdboton.Text.Trim();

                    bool valido = ValidarCoach(user, pass);

                    if (valido)
                    {
                        MessageBox.Show("Inicio de sesión correcto");

                        // Aquí abrirías el siguiente formulario:
                        frmHome frmHome = new frmHome();
                        frmHome.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos");
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmInicio frmInicio = new frmInicio();
            frmInicio.Show();
            this.Hide();
        }
    }
}






        

        

    
        


