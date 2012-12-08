using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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

        /**
         * Private members for internal use only, the user
         * has no knowledge of these whatsoever.
         */
        private bool hasChanged;

        /**
         * Private Constants
         */
        private const int MAX_WORDS_IN_PREVIEW = 10;
        private const int MIN_SPACE_BEFORE_PREVIEW_DATE = 5;
        private const int PREVIEW_DATE_LENGTH = 8;

        /**
         * Constructor
         */
        public Note()
        {
            created = new DateTime();
            modified = new DateTime();
            text = "";
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

        /**
         * Public Methods
         */

        /**
         * previewString() returns a string that is shown for this note in the list
         * of notes on the left side of the application. It includes the first few
         * words of the note, as well as the last modified date, padded with spaces
         * so as to appear right aligned.
         * 
         * Ex:
         *      Note Text: "My favorite things to do over break are spend time with 
         *                  family and program"
         *      Modified Date: 12/8/12 12:37pm
         *      
         *      previewString will return something like this:
         *          "My favorite things      12/8/12"
         *      or
         *          "My favorite things      12:37pm" 
         *      If the last modified date is the current day.
         *      
         * The total number of words inlcuded is based on the available space for 
         * each entry in the list of notes (listWidthPx) and the height of the font
         * being used.
         * 
         * NOTE: It's seeming pretty complicated right now to make this work well...
         *       I'm going to look into other ways. For right now, it's just returning
         *       the first 30 characters of the text.
         */
        public String previewString(/*int listWidthPx, int fontHeight*/)
        {
            /*
            int avgCharWidthPx = fontHeight / 2;

            char[] delimiters = { ' ' };
            String[] firstWords = text.Split(delimiters, MAX_WORDS_IN_PREVIEW, StringSplitOptions.RemoveEmptyEntries);
            */

            return text.Substring(0, 30);
        }
    }
}
