using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace note_taker
{
    class NoteListSerializer
    {
        /**
         * Method to serialize an object to a file
         */
        public bool SerializeObject(string filename, NoteList listToSerialize)
        {
            try
            {
                Stream fileStream = File.Open(filename, FileMode.Create);

                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, listToSerialize);

                fileStream.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            return true;
        }

        /**
         * Method to deserialize an object from a file
         */
        public NoteList DeserializeObject(string filename)
        {
            NoteList notes;

            try
            {
                Stream fileStream = File.Open(filename, FileMode.Open);

                BinaryFormatter formatter = new BinaryFormatter();
                notes = (NoteList)formatter.Deserialize(fileStream);

                fileStream.Close();
            }
            catch (FileNotFoundException)
            {
                return null;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }

            return notes;
        }
    }
}
