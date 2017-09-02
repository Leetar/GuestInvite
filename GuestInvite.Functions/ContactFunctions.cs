// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Class1.cs" company="adasd">
//   asd
// </copyright>
// <summary>
//   Defines the Class1 type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GuestInvite.Functions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GuestInvite.Data;

    public static class ContactFunctions
    {
        public static void AddContact(Contact contact)
        {
            Globals.ContactsInSystem.Add(contact);
        }
    }
}
