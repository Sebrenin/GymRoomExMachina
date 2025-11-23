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
    public partial class ChatControl : UserControl
    {
        public event EventHandler OnContactClick;

        public string CoachId { get; set; }

        // label1 es el nombre del contacto
        public string NombreCoach
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        // label2 es el último mensaje
        public string UltimoMensaje
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }

        public Image FotoCoach
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        public ChatControl()
        {
            InitializeComponent();

            // Conectar los eventos de Click de todos los elementos internos al evento principal
            this.Click += (s, e) => OnContactClick?.Invoke(this, e);
            label1.Click += (s, e) => OnContactClick?.Invoke(this, e);
            label2.Click += (s, e) => OnContactClick?.Invoke(this, e);
            pictureBox1.Click += (s, e) => OnContactClick?.Invoke(this, e);
            pictureBox2.Click += (s, e) => OnContactClick?.Invoke(this, e);

            // Efecto visual: Hover
            this.MouseEnter += (s, e) => this.BackColor = Color.FromArgb(230, 230, 230);
            this.MouseLeave += (s, e) => this.BackColor = SystemColors.Control;
        }


    }
}
