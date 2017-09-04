﻿namespace GuestInvite.Data
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Globals
    {
        private static readonly string SerializedObjectsPathField;

        public static readonly string ContactsSerializedFilename = "Contacts.xml";

        public static readonly string SettingsSerializedFilename = "UserSettings.xml";

        public static readonly string EventsSerializedFilename = "Events.xml";

        public static readonly int? LastUsedId = null;

        static Globals()
        {
            SerializedObjectsPathField = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\XmlData\";

        }

        public static ContactsList ContactsInSystem { get; set; } = new ContactsList();

        public static UserSettings SettingsForUser { get; set; } = new UserSettings();

        public static EventList EventsInSystem { get; set; } = new EventList();

        public static string SerializedObjectsPath { get => SerializedObjectsPathField; }
    }
}
