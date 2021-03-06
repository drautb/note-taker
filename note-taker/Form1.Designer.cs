﻿namespace note_taker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox = new System.Windows.Forms.GroupBox();
            this.notesDataGrid = new System.Windows.Forms.DataGridView();
            this.textColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newNoteButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.noteBox = new System.Windows.Forms.GroupBox();
            this.noteTextArea = new System.Windows.Forms.RichTextBox();
            this.noteModifiedLabel = new System.Windows.Forms.Label();
            this.noteCreatedLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.listBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notesDataGrid)).BeginInit();
            this.noteBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox.Controls.Add(this.notesDataGrid);
            this.listBox.Controls.Add(this.newNoteButton);
            this.listBox.Controls.Add(this.searchBox);
            this.listBox.Location = new System.Drawing.Point(14, 14);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(253, 500);
            this.listBox.TabIndex = 1;
            this.listBox.TabStop = false;
            this.listBox.Text = "Notes";
            // 
            // notesDataGrid
            // 
            this.notesDataGrid.AllowUserToAddRows = false;
            this.notesDataGrid.AllowUserToDeleteRows = false;
            this.notesDataGrid.AllowUserToResizeColumns = false;
            this.notesDataGrid.AllowUserToResizeRows = false;
            this.notesDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.notesDataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.notesDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.notesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notesDataGrid.ColumnHeadersVisible = false;
            this.notesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.textColumn,
            this.modifiedDateColumn});
            this.notesDataGrid.Location = new System.Drawing.Point(7, 58);
            this.notesDataGrid.MinimumSize = new System.Drawing.Size(240, 320);
            this.notesDataGrid.MultiSelect = false;
            this.notesDataGrid.Name = "notesDataGrid";
            this.notesDataGrid.ReadOnly = true;
            this.notesDataGrid.RowHeadersVisible = false;
            this.notesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.notesDataGrid.Size = new System.Drawing.Size(240, 401);
            this.notesDataGrid.TabIndex = 3;
            this.notesDataGrid.SelectionChanged += new System.EventHandler(this.notesDataGrid_SelectionChanged);
            // 
            // textColumn
            // 
            this.textColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.textColumn.FillWeight = 179.0863F;
            this.textColumn.HeaderText = "Note";
            this.textColumn.Name = "textColumn";
            this.textColumn.ReadOnly = true;
            this.textColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.textColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // modifiedDateColumn
            // 
            this.modifiedDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modifiedDateColumn.FillWeight = 60.9137F;
            this.modifiedDateColumn.HeaderText = "Modified";
            this.modifiedDateColumn.Name = "modifiedDateColumn";
            this.modifiedDateColumn.ReadOnly = true;
            this.modifiedDateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.modifiedDateColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // newNoteButton
            // 
            this.newNoteButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.newNoteButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newNoteButton.Location = new System.Drawing.Point(7, 466);
            this.newNoteButton.Name = "newNoteButton";
            this.newNoteButton.Size = new System.Drawing.Size(239, 27);
            this.newNoteButton.TabIndex = 2;
            this.newNoteButton.Text = "New Note";
            this.newNoteButton.UseVisualStyleBackColor = true;
            this.newNoteButton.Click += new System.EventHandler(this.newNoteButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(7, 23);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(238, 28);
            this.searchBox.TabIndex = 0;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // noteBox
            // 
            this.noteBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteBox.Controls.Add(this.noteTextArea);
            this.noteBox.Controls.Add(this.noteModifiedLabel);
            this.noteBox.Controls.Add(this.noteCreatedLabel);
            this.noteBox.Controls.Add(this.deleteButton);
            this.noteBox.Location = new System.Drawing.Point(275, 15);
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(660, 498);
            this.noteBox.TabIndex = 2;
            this.noteBox.TabStop = false;
            // 
            // noteTextArea
            // 
            this.noteTextArea.AcceptsTab = true;
            this.noteTextArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteTextArea.AutoWordSelection = true;
            this.noteTextArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.noteTextArea.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteTextArea.Location = new System.Drawing.Point(10, 22);
            this.noteTextArea.MaxLength = 32767;
            this.noteTextArea.MinimumSize = new System.Drawing.Size(480, 320);
            this.noteTextArea.Name = "noteTextArea";
            this.noteTextArea.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.noteTextArea.Size = new System.Drawing.Size(644, 436);
            this.noteTextArea.TabIndex = 4;
            this.noteTextArea.Text = "";
            this.noteTextArea.TextChanged += new System.EventHandler(this.noteTextArea_TextChanged);
            // 
            // noteModifiedLabel
            // 
            this.noteModifiedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.noteModifiedLabel.AutoSize = true;
            this.noteModifiedLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteModifiedLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.noteModifiedLabel.Location = new System.Drawing.Point(296, 467);
            this.noteModifiedLabel.Name = "noteModifiedLabel";
            this.noteModifiedLabel.Size = new System.Drawing.Size(71, 18);
            this.noteModifiedLabel.TabIndex = 3;
            this.noteModifiedLabel.Text = "Last saved";
            // 
            // noteCreatedLabel
            // 
            this.noteCreatedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.noteCreatedLabel.AutoSize = true;
            this.noteCreatedLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteCreatedLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.noteCreatedLabel.Location = new System.Drawing.Point(7, 466);
            this.noteCreatedLabel.Name = "noteCreatedLabel";
            this.noteCreatedLabel.Size = new System.Drawing.Size(88, 18);
            this.noteCreatedLabel.TabIndex = 2;
            this.noteCreatedLabel.Text = "Note created";
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(566, 465);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(87, 27);
            this.deleteButton.TabIndex = 0;
            this.deleteButton.Text = "Delete Note";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(950, 527);
            this.Controls.Add(this.noteBox);
            this.Controls.Add(this.listBox);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(840, 480);
            this.Name = "MainForm";
            this.Text = "Note Taker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.listBox.ResumeLayout(false);
            this.listBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notesDataGrid)).EndInit();
            this.noteBox.ResumeLayout(false);
            this.noteBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox listBox;
        private System.Windows.Forms.GroupBox noteBox;
        private System.Windows.Forms.Button newNoteButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label noteCreatedLabel;
        private System.Windows.Forms.Label noteModifiedLabel;
        private System.Windows.Forms.DataGridView notesDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn textColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedDateColumn;
        private System.Windows.Forms.RichTextBox noteTextArea;


    }
}

