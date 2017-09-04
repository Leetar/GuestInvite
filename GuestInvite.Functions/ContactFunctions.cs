// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Class1.cs" company="Adam Litarowicz">
//   a
// </copyright>
// <summary>
//   Defines the ContactFunctions type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GuestInvite.Functions
{
    using GuestInvite.Data;

    /// <summary>
    /// The contact functions. Holds methods to operate on contacts.
    /// </summary>
    public static class ContactFunctions
    {
        public static void AddContact(Contact contact)
        {
            Globals.ContactsInSystem.Add(contact);
        }
    }
}
