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
    public partial class ucBurbujaMensaje : UserControl
    {
        public string TextoMensaje
        {
            get { return lblMensaje.Text; }
            set { lblMensaje.Text = value; }
        }

        public bool EsMensajePropio { get; set; }

        public ucBurbujaMensaje()
        {
            InitializeComponent();
        }

        public void RenderizarMensaje(int contenedorAncho)
        {
            // 1. Definir ancho máximo (70% del contenedor)
            int maxBubbleWidth = (int)(contenedorAncho * 0.7);
            lblMensaje.MaximumSize = new Size(maxBubbleWidth - pnlBurbuja.Padding.Left - pnlBurbuja.Padding.Right, 0);

            // 2. Ajustar el tamaño del panel contenedor (la burbuja)
            pnlBurbuja.Width = lblMensaje.PreferredSize.Width + pnlBurbuja.Padding.Left + pnlBurbuja.Padding.Right;
            pnlBurbuja.Height = lblMensaje.PreferredSize.Height + pnlBurbuja.Padding.Top + pnlBurbuja.Padding.Bottom;

            // 3. Aplicar estilo y alineación
            if (EsMensajePropio)
            {
                // Enviado (Derecha)
                pnlBurbuja.BackColor = Color.FromArgb(0, 128, 255); // Azul
                lblMensaje.ForeColor = Color.White;
                // Posicionar a la derecha: (Ancho del contenedor - Ancho de la burbuja - margen)
                pnlBurbuja.Location = new Point(contenedorAncho - pnlBurbuja.Width - 15, 5);
            }
            else
            {
                // Recibido (Izquierda)
                pnlBurbuja.BackColor = Color.LightGray; // Gris claro
                lblMensaje.ForeColor = Color.Black;
                pnlBurbuja.Location = new Point(15, 5);
            }

            // 4. Establecer el tamaño del UserControl 
            this.Size = new Size(contenedorAncho, pnlBurbuja.Height + 10);
        }
    }
}
