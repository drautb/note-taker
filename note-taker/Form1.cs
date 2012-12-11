using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace note_taker
{
    public partial class MainForm : Form
    {
        /**
         * Private members
         */
        private NoteList allNotes = new NoteList();
        private NoteList displayNotes = new NoteList();

        private int selectedNoteIdx = -1; // Index of selected note in displayNotes
        private Note selectedNote;

        private NoteListSerializer serializer = new NoteListSerializer();

        // Component References
        DataGridViewColumn previewTextCol;
        DataGridViewColumn modifiedTextCol;

        /**
         * Constants
         */
        private const String NOTES_FILENAME = "notes.bin";
        private const String NOTES_BACKUP_FILENAME = "notes.bak";

        /**
         * Constructor
         */
        public MainForm()
        {
            InitializeComponent();
            InitDataGrid();

            LoadNotes();
            RefreshDisplayNotes();

            /**
             * RUN TESTS
             */
            /*
            Test();
            /**/
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
         * Subroutine to load notes from file into the program
         */
        private void LoadNotes()
        {            
            allNotes = serializer.DeserializeObject(NOTES_FILENAME);
            if (allNotes == null)
                allNotes = new NoteList();

            //InsertTestNotes();
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
         * This method refreshes the displayNotes container to only contain notes
         * that contain text matching the search criteria. If there is nothing in
         * the search box, it puts all notes there. 
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
         * This method is called when the selected row in the note list changes.
         * It updates all the necessary components to reflect the change.
         */
        private void ChangeSelectedNote(int displayNotesIdx)
        {
            selectedNoteIdx = displayNotesIdx;
            selectedNote = null;

            if (selectedNoteIdx < 0)
            {
                noteTextArea.Text = "";
                noteCreatedLabel.Text = "";
                noteModifiedLabel.Text = "";
                return;
            }

            selectedNote = displayNotes[selectedNoteIdx];

            noteTextArea.Text = selectedNote.Text;

            noteCreatedLabel.Text = "Note created ";
            if (selectedNote.Created.Date == DateTime.Today)
                noteCreatedLabel.Text += "at " + selectedNote.CreatedText;
            else
                noteCreatedLabel.Text += "on " + selectedNote.CreatedText;

            noteModifiedLabel.Text = "Last saved ";
            if (selectedNote.Modified.Date == DateTime.Today)
                noteModifiedLabel.Text += "at " + selectedNote.ModifiedText;
            else
                noteModifiedLabel.Text += "on " + selectedNote.ModifiedText;
        }

        /**
         * Saves all notes in memory to file, regardless of when they were last saved
         * or whether or not they were changed.
         */
        private bool SaveAllNotes()
        {
            if (serializer.SerializeObject(NOTES_FILENAME, allNotes) &&
                serializer.SerializeObject(NOTES_BACKUP_FILENAME, allNotes))
                return true;

            return false;
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
            allNotes.Remove(selectedNote);

            selectedNote = null;
            selectedNoteIdx = -1;

            RefreshDisplayNotes();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            RefreshDisplayNotes();
        }

        private void notesDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            int noteIdx = notesDataGrid.SelectedRows.Count == 1 ? notesDataGrid.SelectedRows[0].Index : -1;
            ChangeSelectedNote(noteIdx);
        }

        private void noteTextArea_TextChanged(object sender, EventArgs e)
        {
            if (selectedNote != null)
                selectedNote.Text = noteTextArea.Text;
        }

        private void MainForm_FormClosing(Object sender, FormClosingEventArgs e)
        {
            // If the save fails, cancel the close and alert the user.
            if (!SaveAllNotes())
            {
                e.Cancel = true;
                MessageBox.Show("For some reason your notes could not be saved. You may try again, or move important notes to another program to ensure they are not lost.");
            }
        }

        /************************
         * TESTING METHODS
         */
        private bool Test()
        {
            InsertTestNotes();
            RefreshDisplayNotes();

            Note currentNote = displayNotes[2];

            currentNote.Text = "New Test Text!";
            String newString = "New Test Text!";

            Debug.Assert(currentNote.Text == newString);
            Debug.Assert(displayNotes[2].Text == newString);
            Debug.Assert(allNotes[2].Text == newString);

            newString = "WORD";

            allNotes[2].Text = "WORD";

            Debug.Assert(currentNote.Text == newString);
            Debug.Assert(displayNotes[2].Text == newString);
            Debug.Assert(allNotes[2].Text == newString);

            return true;
        }

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
                "Test Note #2\r\nI wonder if this newline actually works... In other news, this was Christmas in 2001",
                "I AM NUMBER 3. What a great place to be! This also happens to be tthe day that I graduated from high school!",
                "This is number 4, gondola! This was the day that I entered the MTC to serve a mission in Paris, France.",
                "You know I think gondola's are pretty cool boats. This is the day that I proposed to my girlfriend, Brittney Barlow."
            };

            for (int n=0; n<numNotes; n++)
                allNotes.Add(new Note(creationDates[n], modifiedTimes[n], noteTexts[n]));
        }
    }
}
