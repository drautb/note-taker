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
        private NoteList allNotes = new NoteList();
        private NoteList displayNotes = new NoteList();

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

            InsertTestNotes();
        }

        /**
         * Just a subroutine to hold all the data grid initialization code.
         */
        private void InitDataGrid()
        {
            // Some shorthand references
            previewTextCol = notesDataGrid.Columns["textColumn"];
            modifiedTextCol = notesDataGrid.Columns["modifiedDateColumn"];

            notesDataGrid.AutoGenerateColumns = false;
            notesDataGrid.DataSource = displayNotes;
 
            // Tell the datagrid which properties of a Note object to use in which columns
            previewTextCol.DataPropertyName = "PreviewText";
            modifiedTextCol.DataPropertyName = "ModifiedText";

            modifiedTextCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        /**
         * Method that creates a new note, called when "New Note" is clicked
         */
        private void NewNote()
        {
            allNotes.Add(new Note());

            RefreshDisplayNotes();
        }

        /**
         * This method
         */
        private void RefreshDisplayNotes()
        {
            displayNotes.Clear();

            String searchText = searchBox.Text;

            foreach (Note n in allNotes)
            {
                if (n.Text.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                    displayNotes.Add(n);
            }
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
            RefreshDisplayNotes();
        }

        private void notesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // A Cell in the note list has been clicked. Load the note text into the editor
        }

        private void noteTextArea_TextChanged(object sender, EventArgs e)
        {
            // The text of this note has changed, update the note.
        }

        /************************
         * TESTING METHODS
         */
        private void InsertTestNotes()
        {
            int numNotes = 5;

            DateTime[] creationDates = 
            {
                new DateTime(1999, 8, 11, 17, 32, 03),
                new DateTime(2001, 12, 25, 3, 23, 00),
                new DateTime(2007, 6, 6, 2, 0, 0),
                new DateTime(2008, 12, 17, 3, 22, 0),
                new DateTime(2012, 11, 10, 4, 14, 0)
            };

            DateTime[] modifiedTimes = creationDates;

            String[] noteTexts = 
            {
                "This is the first test note that I'm adding to the set.",
                "Test Note #2\nI wonder if this newline actually works... In other news, this was Christmas in 2001",
                "I AM NUMBER 3. What a great place to be! This also happens to be tthe day that I graduated from high school!",
                "This is number 4, gondola! This was the day that I entered the MTC to serve a mission in Paris, France.",
                "You know I think gondola's are pretty cool boats. This is the day that I proposed to my girlfriend, Brittney Barlow."
            };

            for (int n=0; n<numNotes; n++)
                allNotes.Add(new Note(creationDates[n], modifiedTimes[n], noteTexts[n]));

            RefreshDisplayNotes();
        }
    }
}
