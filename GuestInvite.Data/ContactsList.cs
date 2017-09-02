namespace GuestInvite.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;

    public class ContactsList : List<Contact>
    {
        public void Replace(Contact contactToReplace, Contact ReplacingContact)
        {
            this[this.IndexOf(contactToReplace)] = ReplacingContact;
        }
    }
}
