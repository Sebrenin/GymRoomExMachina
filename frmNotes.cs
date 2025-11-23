using GymRoomExMachina;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymRoom
{
    public partial class frmNotes : Form
    {
        private List<NoteClass> allNotes = new List<NoteClass>();
        private NoteClass _currentNote;

        private string NotesFilePath = "notes.json";

        public frmNotes()
        {
            InitializeComponent();
            LoadNotesFromFile();
        }

        private void frmNotes_Load(object sender, EventArgs e)
        {
            if (!allNotes.Any())
                CreateNewNote();

            LoadNoteInEditor(allNotes.First());
            DisplayNotes();
        }

        // LISTA DE NOTAS 
        private void DisplayNotes()
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var note in allNotes.OrderByDescending(n => n.LastModified))
            {
                var item = new NotesSaved(note);

                item.NoteSelected += (s, selectedNote) =>
                {
                    LoadNoteInEditor(selectedNote);
                };

                item.DeleteRequested += (s, noteToDelete) =>
                {
                    DeleteNote(noteToDelete);
                };

                flowLayoutPanel1.Controls.Add(item);
            }
        }

        //  EDITOR DE NOTA
        private void LoadNoteInEditor(NoteClass note)
        {
            _currentNote = note;
            wrtNote1.CurrentNote = note;
        }

        //  CRUD 
        private void CreateNewNote()
        {
            var newNote = new NoteClass();
            allNotes.Add(newNote);
            SaveNotesToFile();
        }

        private void DeleteNote(NoteClass note)
        {
            allNotes.Remove(note);
            SaveNotesToFile();

            if (allNotes.Any())
                LoadNoteInEditor(allNotes.First());
            else
                CreateNewNote();

            DisplayNotes();
        }

        //GUARDAR
        private void buttonSaveNote_Click(object sender, EventArgs e)
        {
            if (_currentNote == null) return;

            _currentNote.Title = wrtNote1.NoteTitle;
            _currentNote.Content = wrtNote1.NoteContent;


            if (!allNotes.Contains(_currentNote))
                allNotes.Add(_currentNote);

            SaveNotesToFile();
            DisplayNotes();

            _currentNote = new NoteClass();
            LoadNoteInEditor(_currentNote);

        }



        // MÉTODO PARA BORRAR LA NOTA ACTUAL
        private void DeleteCurrentNote()
        {
            if (_currentNote == null)
                return;

            // Eliminar la nota seleccionada
            allNotes.Remove(_currentNote);

            // Guardar cambios en archivo
            SaveNotesToFile();

            // Si ya no quedan notas, crear una nueva vacía
            if (!allNotes.Any())
            {
                var newNote = new NoteClass();
                allNotes.Add(newNote);
                _currentNote = newNote;
            }
            else
            {
                // Cargar la primera nota que quede
                _currentNote = allNotes.First();
            }

            // Actualizar UI (editor y lista)
            wrtNote1.CurrentNote = _currentNote;
            DisplayNotes();
        }



        // EVENTO CLICK DELETE
        private void deletebtn_Click(object sender, EventArgs e)
        {
            DeleteCurrentNote();
        }


        // JSON
        private void LoadNotesFromFile()
        {
            if (!File.Exists(NotesFilePath)) return;

            string json = File.ReadAllText(NotesFilePath);
            allNotes = JsonSerializer.Deserialize<List<NoteClass>>(json);
        }

        private void SaveNotesToFile()
        {
            string json = JsonSerializer.Serialize(allNotes, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(NotesFilePath, json);
        }
        private void SaveCurrentNote()
        {
            if (_currentNote == null)
                return;

            // Actualizar contenido desde el editor
            _currentNote.Title = wrtNote1.NoteTitle;
            _currentNote.Content = wrtNote1.NoteContent;


            // Si la nota NO está en la lista, agregarla
            if (!allNotes.Contains(_currentNote))
                allNotes.Add(_currentNote);

            // Guardar archivo
            SaveNotesToFile();

            // Refrescar la lista visual
            DisplayNotes();
        }


        public void ReloadNotes()
        {
            // Aquí va tu código para recargar las notas desde la base de datos.
            // Incluso puede estar vacío de momento:
        }


        private void flpNotes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.Show();
            this.Hide();
        }




        private void richTextBox1_Click(object sender, EventArgs e)
        {
            //string content = txtContent.Text.Trim();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //string title = txtTitle.Text.Trim();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.Show();
            this.Hide();
        }
    }
}
