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
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SerializationFunctions.DeserializeContacts();
            SerializationFunctions.DeserializeSettings();
            SerializationFunctions.DeserializeEvents();

            if(Globals.LastUsedId == null)

            Application.Run(new EventManager());
        }
    }
}
