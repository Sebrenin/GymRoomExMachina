using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymRoomExMachina
{
    public partial class frmCoachProfile : Form
    {
        private static Dictionary<string, string> _memoriaTemporal = new Dictionary<string, string>();

        public frmCoachProfile()
        {
            InitializeComponent();
            ConfigurarPlaceholders();
        }

        private void frmCoachProfile_Load(object sender, EventArgs e)
        {
            // Al cargar, intentamos recuperar lo que había escrito antes
            RecuperarDatosGuardados();

            // Quitamos el foco de los textboxes para que se vean los textos
            this.ActiveControl = label1;
        }

        // Método que guarda todo en la variable estática antes de salir
        private void GuardarCambiosEnMemoria()
        {
            // Lista de todos tus textboxes
            TextBox[] misCajas = {
                textBox2, // Título
                textBox1, textBox3, textBox4, textBox5, // Certificaciones
                textBox6, textBox7, textBox8, textBox9, // Gyms
                textBox10, textBox11, textBox12, textBox13 // Especialidades
            };

            foreach (var box in misCajas)
            {
                // Guardamos: Clave="textBox1", Valor="Lo que escribiste"
                if (_memoriaTemporal.ContainsKey(box.Name))
                {
                    _memoriaTemporal[box.Name] = box.Text;
                }
                else
                {
                    _memoriaTemporal.Add(box.Name, box.Text);
                }
            }
        }

        // Método que rellena las cajas si hay datos guardados
        private void RecuperarDatosGuardados()
        {
            TextBox[] misCajas = {
                textBox2,
                textBox1, textBox3, textBox4, textBox5,
                textBox6, textBox7, textBox8, textBox9,
                textBox10, textBox11, textBox12, textBox13
            };

            foreach (var box in misCajas)
            {
                // Si existe un dato guardado para esta caja, lo ponemos
                if (_memoriaTemporal.ContainsKey(box.Name))
                {
                    box.Text = _memoriaTemporal[box.Name];

                    // Opcional: Si el texto es diferente al placeholder, podrías cambiar el color
                    // para indicar que es un dato real, pero por ahora lo dejamos simple.
                }
            }
        }

        // ---------------------------------------------------------
        // LOGICA DE PLACEHOLDERS (Texto de ayuda)
        // ---------------------------------------------------------
        private void ConfigurarPlaceholders()
        {
            SetPlaceholder(textBox2, "Main Degree");

            SetPlaceholder(textBox1, "Certificación 1");
            SetPlaceholder(textBox3, "Certificación 2");
            SetPlaceholder(textBox4, "Certificación 3");
            SetPlaceholder(textBox5, "Certificación 4");

            SetPlaceholder(textBox6, "Gimnasio A");
            SetPlaceholder(textBox7, "Gimnasio B");
            SetPlaceholder(textBox8, "Gimnasio C");
            SetPlaceholder(textBox9, "Gimnasio D");

            SetPlaceholder(textBox10, "Especialidad 1");
            SetPlaceholder(textBox11, "Especialidad 2");
            SetPlaceholder(textBox12, "Especialidad 3");
            SetPlaceholder(textBox13, "Especialidad 4");
        }

        private void SetPlaceholder(TextBox txt, string textoSugerencia)
        {
            // Si la caja está vacía o no tiene memoria guardada, ponemos el placeholder
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Text = textoSugerencia;
            }

            txt.Enter += (sender, e) =>
            {
                TextBox t = sender as TextBox;
                if (t.Text == textoSugerencia)
                {
                    t.Text = "";
                }
            };

            txt.Leave += (sender, e) =>
            {
                TextBox t = sender as TextBox;
                if (string.IsNullOrWhiteSpace(t.Text))
                {
                    t.Text = textoSugerencia;
                }
            };
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void label8_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.Show();
            this.Hide();
        }
    }
}
