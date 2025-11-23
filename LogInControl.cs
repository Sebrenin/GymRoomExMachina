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

    public partial class LogInControl : UserControl
    {
        public event EventHandler LoginExitoso;
        public event EventHandler<string> LoginFallido;
        public event EventHandler IrACreateAccount;

        public LogInControl()
        {
            InitializeComponent();

            // Asignar evento al botón
            button1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = userboton.Text;
            string password = pwdboton.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                incorrectUser.Text = "Ingrese usuario y contraseña";
                incorrectUser.Visible = true;
                return;
            }

            string connectionString =
                "Server=DESKTOP-2L7OPJ1\\SQLEXPRESS01;Database=GymRoom Database;Trusted_Connection=True;TrustServerCertificate=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query =
                        "SELECT idCoach FROM Coach WHERE nameCoach = @usuario AND passwordCoach = @password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@usuario", usuario);
                        command.Parameters.AddWithValue("@password", password);

                        object idResult = command.ExecuteScalar();
                        string coachId = idResult?.ToString();

                        if (!string.IsNullOrEmpty(coachId))
                        {
                            incorrectUser.Visible = false;
                            LoginExitoso?.Invoke(this, EventArgs.Empty);

                            //IR A HOME
                            Form parentForm = this.FindForm();
                            parentForm?.Hide();

                            
                            frmHome homeForm = new frmHome();
                            homeForm.Show();

                        }
                        else
                        {
                            incorrectUser.Text = "Usuario o contraseña incorrecta";
                            incorrectUser.Visible = true;

                            LoginFallido?.Invoke(this, "Credenciales incorrectas");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                incorrectUser.Text = "Error SQL: " + ex.Message;
                incorrectUser.Visible = true;
                LoginFallido?.Invoke(this, ex.Message);
            }
        }

        
    }
}

