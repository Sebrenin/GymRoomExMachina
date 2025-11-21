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
    public partial class wrtNote : UserControl
    {
        private NoteClass _currentNote;
        private bool _isPlaceholderActive = false;

        private Color PlaceholderColor = Color.Gray;
        private Color DefaultTextColor = Color.Black;

        public wrtNote()
        {
            InitializeComponent();
            this.Load += wrtNote_Load;
        }

        private void wrtNote_Load(object sender, EventArgs e)
        {
            titulonote.GotFocus += RemovePlaceholder;
            titulonote.LostFocus += SetPlaceholder;
            contenidonote.GotFocus += RemovePlaceholder;
            contenidonote.LostFocus += SetPlaceholder;
        }

        public NoteClass CurrentNote
        {
            get => _currentNote;
            set
            {
                _currentNote = value;

                if (_currentNote != null)
                {
                    titulonote.Text = string.IsNullOrEmpty(_currentNote.Title)
                        ? "Title Note"
                        : _currentNote.Title;

                    contenidonote.Text = string.IsNullOrEmpty(_currentNote.Content)
                        ? "Write a note here..."
                        : _currentNote.Content;

                    SetPlaceholder(titulonote, EventArgs.Empty);
                    SetPlaceholder(contenidonote, EventArgs.Empty);
                }
            }
        }

        public string NoteTitle => titulonote.ForeColor == PlaceholderColor ? "" : titulonote.Text.Trim();
        public string NoteContent => contenidonote.ForeColor == PlaceholderColor ? "" : contenidonote.Text;

        private void SetPlaceholder(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            string defaultText =
                (control == titulonote) ? "Title Note" : "Write a note here...";

            if (string.IsNullOrWhiteSpace(control.Text))
            {
                control.Text = defaultText;
                control.ForeColor = PlaceholderColor;
            }
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            string defaultText =
                (control == titulonote) ? "Title Note" : "Write a note here...";

            if (control.Text == defaultText)
            {
                control.Text = "";
                control.ForeColor = DefaultTextColor;
            }
        }
    }
}
