// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContactsList.cs" company="Adam Litarowicz">
//   a
// </copyright>
// <summary>
//   Defines the ContactsList type. Represents list of all contacts a usuer has created.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GuestInvite.Data
{
    using System.Collections.Generic;

    /// <inheritdoc />
    /// <summary>
    /// The contacts list. Represents list of all contacts a usuer has created.
    /// </summary>
    public class ContactsList : List<Contact>
    {
        /// <summary>
        /// The replace. Handles replacing of contacts.
        /// </summary>
        /// <param name="contactToReplace">
        /// The contact to replace. this contact will be replaced.
        /// </param>
        /// <param name="replacingContact">
        /// The replacing contact. this contact will replace another contact.
        /// </param>
        public void Replace(Contact contactToReplace, Contact replacingContact)
        {
            this[this.IndexOf(contactToReplace)] = replacingContact;
        }
    }
}
