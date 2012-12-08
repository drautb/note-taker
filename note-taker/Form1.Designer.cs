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
            this.noteBox = new System.Windows.Forms.GroupBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.newNoteButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.noteTextArea = new System.Windows.Forms.TextBox();
            this.listBox.SuspendLayout();
            this.noteBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Controls.Add(this.newNoteButton);
            this.listBox.Controls.Add(this.listBox1);
            this.listBox.Controls.Add(this.searchBox);
            this.listBox.Location = new System.Drawing.Point(12, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(217, 433);
            this.listBox.TabIndex = 1;
            this.listBox.TabStop = false;
            this.listBox.Text = "Notes";
            // 
            // noteBox
            // 
            this.noteBox.Controls.Add(this.noteTextArea);
            this.noteBox.Controls.Add(this.deleteButton);
            this.noteBox.Location = new System.Drawing.Point(236, 13);
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(566, 432);
            this.noteBox.TabIndex = 2;
            this.noteBox.TabStop = false;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(6, 20);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(205, 20);
            this.searchBox.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Info;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.Location = new System.Drawing.Point(6, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 352);
            this.listBox1.TabIndex = 1;
            // 
            // newNoteButton
            // 
            this.newNoteButton.Location = new System.Drawing.Point(6, 404);
            this.newNoteButton.Name = "newNoteButton";
            this.newNoteButton.Size = new System.Drawing.Size(205, 23);
            this.newNoteButton.TabIndex = 2;
            this.newNoteButton.Text = "New Note";
            this.newNoteButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(485, 403);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 0;
            this.deleteButton.Text = "Delete Note";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // noteTextArea
            // 
            this.noteTextArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.noteTextArea.Location = new System.Drawing.Point(6, 19);
            this.noteTextArea.Multiline = true;
            this.noteTextArea.Name = "noteTextArea";
            this.noteTextArea.Size = new System.Drawing.Size(554, 378);
            this.noteTextArea.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(814, 457);
            this.Controls.Add(this.noteBox);
            this.Controls.Add(this.listBox);
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


    }
}

