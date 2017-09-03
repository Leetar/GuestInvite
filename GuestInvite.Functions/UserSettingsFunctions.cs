// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserSettingsFunctions.cs" company="Adam Litarowicz">
//   a
// </copyright>
// <summary>
//   Defines the UserSettingsFunctions type. Provides functions to manipulate on user settings data.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GuestInvite.Functions
{
    public class UserSettingsFunctions
    {
        public void SaveUserSettings()
        {
            SerializationFunctions.SerializeSettings();
        }
    }
}
