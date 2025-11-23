using GymRoom;
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
    public class CoachData
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string UltimoMensaje { get; set; }
        // Guarda el historial de la conversación (Item1: Texto, Item2: EsPropio)
        public List<Tuple<string, bool>> HistorialChat { get; set; } = new List<Tuple<string, bool>>();
    }

    public partial class Mychats : Form
    {
        // Campos de instancia
        private List<CoachData> _listaCoaches;
        private CoachData _coachSeleccionado;

        public Mychats()
        {
            InitializeComponent();

            // Conectar eventos necesarios
            this.Load += Mychats_Load;
            btnenviar.Click += btnenviar_Click; // btnenviar es el PictureBox para enviar

            InicializarCoaches();
        }

        private void InicializarCoaches()
        {
            // Datos simulados
            _listaCoaches = new List<CoachData>
            {
                new CoachData { ID = "C001", Nombre = "Coach Natalia", UltimoMensaje = "¡Tu rutina de hoy está lista!" },
                new CoachData { ID = "C002", Nombre = "Coach Alex", UltimoMensaje = "Me cuentas cómo te fue con el cardio." },
                new CoachData { ID = "C003", Nombre = "Coach David", UltimoMensaje = "Pregunta por horarios disponibles." }
            };
        }

        private void Mychats_Load(object sender, EventArgs e)
        {
            CargarListaContactos();
            // Cargar el chat del primer contacto al iniciar
            if (_listaCoaches.Any())
            {
                _coachSeleccionado = _listaCoaches.First();
                CargarChat(_coachSeleccionado);
            }
        }

        private void CargarListaContactos()
        {
            // pnlContactsContainer es el FlowLayoutPanel de la izquierda
            pnlContactsContainer.Controls.Clear();

            foreach (var coach in _listaCoaches)
            {
                ChatControl uc = new ChatControl
                {
                    CoachId = coach.ID,
                    NombreCoach = coach.Nombre,
                    UltimoMensaje = coach.UltimoMensaje,
                    Width = pnlContactsContainer.ClientSize.Width - 5
                };

                uc.OnContactClick += Contacto_Click;
                pnlContactsContainer.Controls.Add(uc);
            }
        }

        private void Contacto_Click(object sender, EventArgs e)
        {
            ChatControl contactoClickeado = sender as ChatControl;
            if (contactoClickeado != null)
            {
                _coachSeleccionado = _listaCoaches.FirstOrDefault(c => c.ID == contactoClickeado.CoachId);

                if (_coachSeleccionado != null)
                {
                    CargarChat(_coachSeleccionado);
                }
            }
        }

        private void CargarChat(CoachData coach)
        {
            // pnlChatContainer es el FlowLayoutPanel central
            pnlChatContainer.Controls.Clear();

            // label1 es el nombre del coach en la parte superior del chat
            label1.Text = coach.Nombre;

            // Cargar el historial
            foreach (var mensaje in coach.HistorialChat)
            {
                AgregarBurbuja(mensaje.Item1, mensaje.Item2);
            }
        }

        // --- LÓGICA DE ENVÍO Y RESPUESTA SIMULADA ---
        private async void btnenviar_Click(object sender, EventArgs e)
        {
            string mensajeUsuario = txtmensaje.Text.Trim(); // txtmensaje es el TextBox de input

            if (!string.IsNullOrEmpty(mensajeUsuario) && _coachSeleccionado != null)
            {
                // 1. Agregar mensaje enviado y guardarlo
                AgregarBurbuja(mensajeUsuario, true);
                _coachSeleccionado.HistorialChat.Add(new Tuple<string, bool>(mensajeUsuario, true));

                // 2. Limpiar el input
                txtmensaje.Clear();

                // 3. Simular la respuesta del coach (con un pequeño retraso)
                await Task.Delay(500);

                string respuesta = GenerarRespuestaAutomatica(mensajeUsuario, _coachSeleccionado.Nombre);
                AgregarBurbuja(respuesta, false); // false = Mensaje Recibido
                _coachSeleccionado.HistorialChat.Add(new Tuple<string, bool>(respuesta, false));

                // 4. Actualizar el "último mensaje"
                _coachSeleccionado.UltimoMensaje = respuesta;
                CargarListaContactos(); // Recargar la lista para reflejar el nuevo mensaje.
            }
        }

        private void AgregarBurbuja(string texto, bool esPropio)
        {
            ucBurbujaMensaje burbuja = new ucBurbujaMensaje();
            burbuja.TextoMensaje = texto;
            burbuja.EsMensajePropio = esPropio;

            burbuja.RenderizarMensaje(pnlChatContainer.ClientSize.Width);

            pnlChatContainer.Controls.Add(burbuja);

            // Hacer scroll automáticamente al final
            pnlChatContainer.ScrollControlIntoView(burbuja);
        }

        private string GenerarRespuestaAutomatica(string input, string nombreCoach)
        {
            string lowerInput = input.ToLower();

            if (lowerInput.Contains("rutina") || lowerInput.Contains("ejercicio"))
                return "¡Claro! La rutina para ti hoy es de pierna. Recuerda calentar bien. 💪";
            if (lowerInput.Contains("horario") || lowerInput.Contains("disponible"))
                return $"Hola, soy {nombreCoach}. Estoy disponible de 8:00 AM a 6:00 PM. ¿Te agendo?";
            if (lowerInput.Contains("hola") || lowerInput.Contains("saludos"))
                return $"¡Hola! Soy {nombreCoach}, tu coach. ¿En qué puedo ayudarte hoy?";

            return "Entendido. ¡Excelente pregunta! Lo reviso y te confirmo pronto.";
        }

        // Método Go back (label8_Click)
        private void label8_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.Show();
            this.Hide();
        }
    }
}
