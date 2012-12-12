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
using System.Runtime.InteropServices;

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

        private Timer saveTimer = new Timer();

        // Component References
        private DataGridViewColumn previewTextCol;
        private DataGridViewColumn modifiedTextCol;

        /**
         * Constants
         */
        private const String NOTES_FILENAME = "notes.bin";
        private const String NOTES_BACKUP_FILENAME = "notes.bak";

        private const int EM_SETTABSTOPS = 0x00CB;
        private const int FONT_TO_TEMPLATE_WIDTH_RATIO = 4;
        private const int TAB_WIDTH = 4;

        private const int TIME_BETWEEN_SAVES = 60000; // 1 minute

        /**
         * Constructor
         */
        public MainForm()
        {
            InitializeComponent();
            InitDataGrid();
            InitSaveTimer();

            SetTabWidth(noteTextArea, TAB_WIDTH);

            LoadNotes();
            RefreshDisplayNotes();
        }

        /**
         * Subroutine to change the tab size
         * 
         * Based on this page:
         * http://stackoverflow.com/questions/1298406/how-to-set-the-tab-width-in-a-windows-forms-textbox-control
         * 
         */
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr h, int msg, int wParam, int[] lParam);

        public static void SetTabWidth(TextBox textBox, int tabWidth)
        {
            Graphics g = textBox.CreateGraphics();

            SendMessage(textBox.Handle, EM_SETTABSTOPS, 1, new int[] { tabWidth * FONT_TO_TEMPLATE_WIDTH_RATIO });
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
         * Subroutine to setup the save timer
         */
        private void InitSaveTimer()
        {
            saveTimer.Interval = TIME_BETWEEN_SAVES;
            saveTimer.Tick += new System.EventHandler(SaveTimerTick);
            saveTimer.Enabled = true;

            ResetSaveTimer();
        }

        private void ResetSaveTimer()
        {
            saveTimer.Stop();
            saveTimer.Start();
        }

        private void SaveTimerTick(Object sender, EventArgs e)
        {
            SaveAllNotes();
        }

        /**
         * Subroutine to load notes from file into the program
         */
        private void LoadNotes()
        {            
            allNotes = serializer.DeserializeObject(NOTES_FILENAME);
            if (allNotes == null)
                allNotes = new NoteList();
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
            // Save the selected row index
            int selectedRowIdx = -1;
            if (notesDataGrid.SelectedRows.Count > 0)
                selectedRowIdx = notesDataGrid.SelectedRows[0].Index;

            // Refresh the list
            displayNotes.Clear();

            String searchText = searchBox.Text;

            foreach (Note n in allNotes)
            {
                if (n.Text.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                    displayNotes.Add(n);
            }

            // Restore the selected row, or close to it if possible
            if (selectedRowIdx == notesDataGrid.RowCount)
                selectedRowIdx--;

            foreach (DataGridViewRow row in notesDataGrid.Rows)
            {
                if (row.Index == selectedRowIdx)
                    row.Selected = true;
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
            if (serializer.SerializeObject(NOTES_FILENAME, allNotes))
                return true;

            return false;
        }

        /**
         * Saves all notes to regular file as well as to backup file
         */
        private bool BackupNotes()
        {
            if (SaveAllNotes() && serializer.SerializeObject(NOTES_BACKUP_FILENAME, allNotes))
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

            // Redraw the note list to show updated previews
            notesDataGrid.Invalidate();
        }

        private void MainForm_FormClosing(Object sender, FormClosingEventArgs e)
        {
            // If the save fails, cancel the close and alert the user.
            if (!BackupNotes())
            {
                e.Cancel = true;
                MessageBox.Show("For some reason your notes could not be saved. You may try again, or move important notes to another program to ensure they are not lost.",
                                "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
