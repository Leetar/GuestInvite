// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SerializationFunctions.cs" company="Adam Litarowicz">
//   MIT license
// </copyright>
// <summary>
//   Defines the SerializationFunctions type. Provides functions to serialize data into xml format, and to deserialize them.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GuestInvite.Functions
{
    using System;
    using System.IO;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;
    using GuestInvite.Data;

    public static class SerializationFunctions
    {
        /// <summary>
        /// The serialize settings. Serializes user settings into a xml format.
        /// </summary>
        public static void SerializeSettings()
        {
            if (!Directory.Exists(Globals.SerializedObjectsPath))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(Globals.SerializedObjectsPath) ?? throw new InvalidOperationException());
            }

            XmlSerializer serializer = new XmlSerializer(Globals.SettingsForUser.GetType());

            using (Stream fs = new FileStream(Globals.SerializedObjectsPath + Globals.SettingsSerializedFilename, FileMode.Create))
            {
                using (XmlWriter writer = new XmlTextWriter(fs, Encoding.Unicode))
                {
                    serializer.Serialize(writer, Globals.SettingsForUser);
                    writer.Close();
                }
            }
        }

        /// <summary>
        /// The deserialize settings. deserializes user settings into a xml format.
        /// </summary>
        public static void DeserializeSettings()
        {
            if (!File.Exists(Globals.SerializedObjectsPath + Globals.ContactsSerializedFilename))
            {
                return;
            }

            XmlSerializer serializer = new XmlSerializer(Globals.SettingsForUser.GetType());

            using (FileStream fileStream = new FileStream(Globals.SerializedObjectsPath + Globals.SettingsSerializedFilename, FileMode.Open))
            {
                Globals.SettingsForUser = (UserSettings)serializer.Deserialize(fileStream);
            }
        }

        /// <summary>
        /// The serialize contacts. Serializes contacts created by user.
        /// </summary>
        public static void SerializeContacts()
        {
            if (!Directory.Exists(Globals.SerializedObjectsPath))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(Globals.SerializedObjectsPath) ?? throw new InvalidOperationException());
            }

            XmlSerializer serializer = new XmlSerializer(Globals.ContactsInSystem.GetType());

            using (Stream fs = new FileStream(Globals.SerializedObjectsPath + Globals.ContactsSerializedFilename, FileMode.Create))
            {
                using (XmlWriter writer = new XmlTextWriter(fs, Encoding.Unicode))
                {
                    serializer.Serialize(writer, Globals.ContactsInSystem);
                    writer.Close();
                }
            }
        }

        /// <summary>
        /// The deserialize contacts. Deserializes contacts added by user.
        /// </summary>
        public static void DeserializeContacts()
        {
            if (!File.Exists(Globals.SerializedObjectsPath + Globals.ContactsSerializedFilename))
            {
                return;
            }

            XmlSerializer serializer = new XmlSerializer(Globals.ContactsInSystem.GetType());

            using (FileStream fileStream = new FileStream(Globals.SerializedObjectsPath + Globals.ContactsSerializedFilename, FileMode.Open))
            {
                Globals.ContactsInSystem = (ContactsList)serializer.Deserialize(fileStream);
            }
        }

        /// <summary>
        /// The serialize events. Serializes events created by the user into xml format.
        /// </summary>
        public static void SerializeEvents()
        {
            if (!Directory.Exists(Globals.SerializedObjectsPath))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(Globals.SerializedObjectsPath) ?? throw new InvalidOperationException());
            }

            XmlSerializer serializer = new XmlSerializer(Globals.EventsInSystem.GetType());

            using (Stream fs = new FileStream(Globals.SerializedObjectsPath + Globals.EventsSerializedFilename, FileMode.Create))
            {
                using (XmlWriter writer = new XmlTextWriter(fs, Encoding.Unicode))
                {
                    serializer.Serialize(writer, Globals.EventsInSystem);
                    writer.Close();
                }
            }
        }

        /// <summary>
        /// The deserialize events. Deserializes events from xml.
        /// </summary>
        public static void DeserializeEvents()
        {
            if (!File.Exists(Globals.SerializedObjectsPath + Globals.EventsSerializedFilename))
            {
                return;
            }

            XmlSerializer serializer = new XmlSerializer(Globals.EventsInSystem.GetType());

            using (FileStream fileStream = new FileStream(Globals.SerializedObjectsPath + Globals.EventsSerializedFilename, FileMode.Open))
            {
                Globals.EventsInSystem = (EventList)serializer.Deserialize(fileStream);
            }
        }
    }
}
