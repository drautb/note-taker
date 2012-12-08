namespace note_taker
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
            this.newNoteButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.noteBox = new System.Windows.Forms.GroupBox();
            this.noteTextArea = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.noteCreatedLabel = new System.Windows.Forms.Label();
            this.noteModifiedLabel = new System.Windows.Forms.Label();
            this.listBox.SuspendLayout();
            this.noteBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Controls.Add(this.newNoteButton);
            this.listBox.Controls.Add(this.listBox1);
            this.listBox.Controls.Add(this.searchBox);
            this.listBox.Location = new System.Drawing.Point(14, 14);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(253, 500);
            this.listBox.TabIndex = 1;
            this.listBox.TabStop = false;
            this.listBox.Text = "Notes";
            // 
            // newNoteButton
            // 
            this.newNoteButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newNoteButton.Location = new System.Drawing.Point(7, 466);
            this.newNoteButton.Name = "newNoteButton";
            this.newNoteButton.Size = new System.Drawing.Size(239, 27);
            this.newNoteButton.TabIndex = 2;
            this.newNoteButton.Text = "New Note";
            this.newNoteButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Info;
            this.listBox1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(7, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(238, 396);
            this.listBox1.TabIndex = 1;
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(7, 23);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(238, 28);
            this.searchBox.TabIndex = 0;
            // 
            // noteBox
            // 
            this.noteBox.Controls.Add(this.noteModifiedLabel);
            this.noteBox.Controls.Add(this.noteCreatedLabel);
            this.noteBox.Controls.Add(this.noteTextArea);
            this.noteBox.Controls.Add(this.deleteButton);
            this.noteBox.Location = new System.Drawing.Point(275, 15);
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(660, 498);
            this.noteBox.TabIndex = 2;
            this.noteBox.TabStop = false;
            // 
            // noteTextArea
            // 
            this.noteTextArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.noteTextArea.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteTextArea.Location = new System.Drawing.Point(7, 22);
            this.noteTextArea.Multiline = true;
            this.noteTextArea.Name = "noteTextArea";
            this.noteTextArea.Size = new System.Drawing.Size(646, 436);
            this.noteTextArea.TabIndex = 1;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(566, 465);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(87, 27);
            this.deleteButton.TabIndex = 0;
            this.deleteButton.Text = "Delete Note";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // noteCreatedLabel
            // 
            this.noteCreatedLabel.AutoSize = true;
            this.noteCreatedLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteCreatedLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.noteCreatedLabel.Location = new System.Drawing.Point(7, 466);
            this.noteCreatedLabel.Name = "noteCreatedLabel";
            this.noteCreatedLabel.Size = new System.Drawing.Size(230, 18);
            this.noteCreatedLabel.TabIndex = 2;
            this.noteCreatedLabel.Text = "Note created on 12/8/12 at 12:00pm";
            // 
            // noteModifiedLabel
            // 
            this.noteModifiedLabel.AutoSize = true;
            this.noteModifiedLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteModifiedLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.noteModifiedLabel.Location = new System.Drawing.Point(296, 467);
            this.noteModifiedLabel.Name = "noteModifiedLabel";
            this.noteModifiedLabel.Size = new System.Drawing.Size(213, 18);
            this.noteModifiedLabel.TabIndex = 3;
            this.noteModifiedLabel.Text = "Last saved on 12/8/12 at 12:05pm";
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Note Taker";
            this.listBox.ResumeLayout(false);
            this.listBox.PerformLayout();
            this.noteBox.ResumeLayout(false);
            this.noteBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox listBox;
        private System.Windows.Forms.GroupBox noteBox;
        private System.Windows.Forms.Button newNoteButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox noteTextArea;
        private System.Windows.Forms.Label noteCreatedLabel;
        private System.Windows.Forms.Label noteModifiedLabel;


    }
}

