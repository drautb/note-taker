using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace note_taker
{
    /**
     * This is a custom class to hold a list of notes, it implements 
     * ITypedList to allow for data binding.
     */
    [Serializable()]
    class NoteList : BindingList<Note>, ITypedList
    {
        /**
         * This method implementation is required by the ITypedList interface
         */
        public PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors)
        {
            PropertyDescriptorCollection pdc = TypeDescriptor.GetProperties(typeof(Note));

            return pdc;
        }

        /**
         * This method implementation is required by the ITypedList interface
         */
        public string GetListName(PropertyDescriptor[] listAccessors)
        {
            return typeof(Note).Name;
        }
    }
}
