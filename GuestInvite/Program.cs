using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuestInvite
{
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
            Application.Run(new MainWindow());
        }
    }
}
