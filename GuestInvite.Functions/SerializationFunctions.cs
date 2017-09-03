// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SerializationFunctions.cs" company="Adam Litarowicz">
//   a
// </copyright>
// <summary>
//   Defines the SerializationFunctions type. Provides functions to serialize data into xml format, and to deserialize them.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GuestInvite.Functions
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;
    using GuestInvite.Data;

    public static class SerializationFunctions
    {
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

        public static void DeserializeSettings()
        {
            if (File.Exists(Globals.SerializedObjectsPath + Globals.ContactsSerializedFilename))
            {
                XmlSerializer serializer = new XmlSerializer(Globals.SettingsForUser.GetType());

                using (FileStream fileStream = new FileStream(Globals.SerializedObjectsPath + Globals.SettingsSerializedFilename, FileMode.Open))
                {
                    Globals.SettingsForUser = (UserSettings)serializer.Deserialize(fileStream);
                }
            }
        }

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

        public static void DeserializeContacts()
        {
            if (File.Exists(Globals.SerializedObjectsPath + Globals.ContactsSerializedFilename))
            {
                XmlSerializer serializer = new XmlSerializer(Globals.ContactsInSystem.GetType());

                using (FileStream fileStream = new FileStream(Globals.SerializedObjectsPath + Globals.ContactsSerializedFilename, FileMode.Open))
                {
                    Globals.ContactsInSystem = (ContactsList)serializer.Deserialize(fileStream);
                }
            }
        }

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

        public static void DeserializeEvents()
        {
            if (File.Exists(Globals.SerializedObjectsPath + Globals.EventsSerializedFilename))
            {
                XmlSerializer serializer = new XmlSerializer(Globals.ContactsInSystem.GetType());

                using (FileStream fileStream = new FileStream(Globals.SerializedObjectsPath + Globals.EventsSerializedFilename, FileMode.Open))
                {
                    Globals.EventsInSystem = (EventList)serializer.Deserialize(fileStream);
                }
            }
        }
    }
}
