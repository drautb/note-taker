using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace note_taker
{
    public partial class MainForm : Form
    {
        /**
         * Private members
         */
        private NoteList notes = new NoteList();

        // Component References
        DataGridViewColumn previewTextCol;
        DataGridViewColumn modifiedTextCol;

        /**
         * Constructor
         */
        public MainForm()
        {
            InitializeComponent();

            InitDataGrid();
        }

        /**
         * Just a subroutine to hold all the data grid initialization code.
         */
        private void InitDataGrid()
        {
            previewTextCol = notesDataGrid.Columns["textColumn"];
            modifiedTextCol = notesDataGrid.Columns["modifiedDateColumn"];

            notesDataGrid.AutoGenerateColumns = false;
            notesDataGrid.DataSource = notes;
            previewTextCol.DataPropertyName = "PreviewText";
            modifiedTextCol.DataPropertyName = "ModifiedText";
            modifiedTextCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        /**
         * Method that creates a new note, called when "New Note" is clicked
         */
        private void NewNote()
        {
            notes.Add(new Note());
        }

        /**
         * Form Component Event Responders
         */
        private void newNoteButton_Click(object sender, EventArgs e)
        {
            NewNote();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // The selected note needs to be deleted.
            // Remove it from the NoteList
            // Remove it from the saved file
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            // The search box text has changed
            // If it's empty, add all notes to the display list
            // If it's not empty, update the display list to only contain notes whose
            // text contains the search phrase.
        }

        private void notesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // A Cell in the note list has been clicked. Load the note text into the editor
        }

        private void noteTextArea_TextChanged(object sender, EventArgs e)
        {
            // The text of this note has changed, update the note.
        }
    }
}
