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
    public partial class NotesSaved : UserControl
    {

        public event EventHandler<NoteClass> NoteSelected;
        public event EventHandler<NoteClass> DeleteRequested;

        private NoteClass _associatedNote;

        public NotesSaved(NoteClass note)
        {
            InitializeComponent();
            _associatedNote = note;

            textBox1.Text = note.Title;
            

            ConnectEvents();
        }

        private void ConnectEvents()
        {
            this.Click += NotesSaved_Click;

            foreach (Control c in this.Controls)
            {
                if (c == DeleteButton)
                    DeleteButton.Click += DeleteButton_Click;
                else
                    c.Click += NotesSaved_Click;
            }
        }

        private void NotesSaved_Click(object sender, EventArgs e)
        {
            NoteSelected?.Invoke(this, _associatedNote);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteRequested?.Invoke(this, _associatedNote);
        }

    }
}

        
   
