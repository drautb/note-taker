using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace note_taker
{
    /**
     * Represents a Note.
     * 
     * Each note has a creation date, last modified date, and text.
     * The text is the body of the note. A note does not have a title. 
     * The "Title" shown in the left column is just an excerpt from the first part of the note.
     * 
     */
    class Note
    {
        /**
         * Private Members
         */
        private DateTime created;

        private DateTime modified;

        private String text;

        private String previewText;

        /**
         * Private members for internal use only, the user
         * has no knowledge of these whatsoever.
         */
        private bool hasChanged;

        /**
         * Private Constants
         */
        private const int MAX_WORDS_IN_PREVIEW = 5;

        /**
         * Constructor
         */
        public Note()
        {
            created = new DateTime(DateTime.Now.Ticks);
            modified = new DateTime(DateTime.Now.Ticks);
            text = "";
            previewText = "";
        }

        /**
         * Constructor used ONLY for testing!
         */
        public Note(DateTime created, DateTime modified, String text)
        {
            this.created = created;
            this.modified = modified;
            this.text = text;
            UpdatePreviewText();
        }

        /**
         * Getters/Setters
         */
        public DateTime Created
        {
            /**
             * The created date is set at the time of creation,
             * and cannot be changed.
             */
            get
            {
                return created;
            }
            set { }
        }

        public DateTime Modified
        {
            /**
             * The modified date is updated each time the note is
             * written to file. It cannot be changed explicitly.
             */
            get
            {
                return modified;
            }
            set { }
        }

        public String Text
        {
            /**
             * The text value may be changed at any time by the user.
             * When it is changed, the change is saved in memory.
             * The note classes utilizes internal timers and variable to 
             * know when to save the the note to file. 
             */
            get
            {
                return text;
            }
            set
            {
                text = value;

                hasChanged = true;
            }
        }

        public String PreviewText
        {
            get
            {
                return previewText;
            }
            set { }
        }

        /**
         * These properties are used to populate the data grid control
         */
        public String ModifiedText
        {
            get
            {
                if (modified.Date == DateTime.Today)
                    return modified.ToString("h:mm tt");
                else
                    return modified.ToString("M/d/yy");
            }
            set { }
        }

        /**
         * Public Methods
         */


        /**
         * Private Methods
         */

        /**
         * This method should be called anytime the preview text needs to 
         * be updated. It can be intense though on long notes because of 
         * the "Split" call, so I'm anticipating only calling it when the 
         * notes are saved to file.
         */
        private void UpdatePreviewText()
        {
            char[] delimiters = { ' ' };
            String[] words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            previewText = "";
            for (int w = 0; w < MAX_WORDS_IN_PREVIEW && w < words.Length; w++)
                previewText += words[w] + " ";
        }
    }
}
