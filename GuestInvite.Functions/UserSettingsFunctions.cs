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
    /// <summary>
    /// The user settings functions. Contains function that can be performed of UserSettings class.
    /// </summary>
    public class UserSettingsFunctions
    {
        /// <summary>
        /// The save user settings. Serializes settings.
        /// </summary>
        public void SaveUserSettings()
        {
            SerializationFunctions.SerializeSettings();
        }
    }
}
