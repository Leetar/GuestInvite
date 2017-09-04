// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Globals.cs" company="Adam Litarowicz">
//   a
// </copyright>
// <summary>
//   Defines the Globals type. Holds all global variables.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GuestInvite.Data
{
    using System.Diagnostics;
    using System.IO;

    public static class Globals
    {
        /// <summary>
        /// The contacts serialized filename. Filename and extension that ContactsList object will be serialized to.
        /// </summary>
        public static readonly string ContactsSerializedFilename = "Contacts.xml";

        /// <summary>
        /// The settings serialized filename.Filename and extension that UserSettings object will be serialized to.
        /// </summary>
        public static readonly string SettingsSerializedFilename = "UserSettings.xml";

        /// <summary>
        /// The events serialized filename. Filename and extension that EventsList object will be serialized to.
        /// </summary>
        public static readonly string EventsSerializedFilename = "Events.xml";

        /// <summary>
        /// Initializes static members of the <see cref="Globals"/> class. Sets path to which program will save data to, based on programs current location.
        /// </summary>
        static Globals()
        {
            SerializedObjectsPath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\XmlData\";

        }

        public static ContactsList ContactsInSystem { get; set; } = new ContactsList();

        public static UserSettings SettingsForUser { get; set; } = new UserSettings();

        public static EventList EventsInSystem { get; set; } = new EventList();

        public static string SerializedObjectsPath { get; }
    }
}
