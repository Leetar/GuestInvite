// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserSettings.cs" company="Adam Litarowicz">
//   a
// </copyright>
// <summary>
//   Defines the UserSettings type. Holds all user settings.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GuestInvite.Data
{
    /// <summary>
    /// The user settings. Holds all user settings.
    /// </summary>
    public class UserSettings
    {
        /// <summary>
        /// Gets or sets the disparity threshold. how big of a difference must there be between number of male and female contacts invited to event
        /// must there be for warning message to be displayed.
        /// </summary>
        public int DisparityTreshold { get; set; }
    }
}
