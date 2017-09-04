// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Adam Litarowicz">
// a
// </copyright>
// <summary>
//   Defines the Program type. Startup class for this program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GuestInvite
{
    using System;
    using System.Windows.Forms;

    using GuestInvite.Data;
    using GuestInvite.Functions;
    using GuestInvite.UI;

    static class Program
    {
        /// <summary>
        /// The main entry point for the application. Deserializes saved data from disk.
        /// </summary>
        [STAThread]
        internal static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SerializationFunctions.DeserializeContacts();
            SerializationFunctions.DeserializeSettings();
            SerializationFunctions.DeserializeEvents();

            Application.Run(new EventManager());
        }
    }
}
