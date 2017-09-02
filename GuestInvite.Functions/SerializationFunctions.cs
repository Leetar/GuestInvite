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
        public static void SerializeContacts()
        {
            if (!Directory.Exists(Globals.SerializedObjectsPath))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(Globals.SerializedObjectsPath) ?? throw new InvalidOperationException());
            }

            XmlSerializer serializer = new XmlSerializer(Globals.ContactsInSystem.GetType());

            using (Stream fs = new FileStream(Globals.SerializedObjectsPath + "Contacts.xml", FileMode.Create))
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
    }
}
