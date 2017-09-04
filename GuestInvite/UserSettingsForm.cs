// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserSettingsForm.cs" company="Adam Litarowicz">
//   a
// </copyright>
// <summary>
//   Defines the UserSettingsForm type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GuestInvite.UI
{
    using System;
    using System.Windows.Forms;

    using GuestInvite.Data;
    using GuestInvite.Functions;

    /// <inheritdoc />
    /// <summary>
    /// The user settings form. Form, on which user chooses his settings for this application.
    /// </summary>
    public partial class UserSettingsForm : Form
    {
        public UserSettingsForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// The set selected settings. Sets settings into global settings variable.
        /// </summary>
        private void SetSelectedSettings()
        {
            UserSettings settings = new UserSettings { DisparityTreshold = Convert.ToInt32(this.nupGender.Value) };

            Globals.SettingsForUser = settings;
        }

        /// <summary>
        /// The button save click. saves user settings into mxl format.
        /// </summary>
        /// <param name="sender">
        /// The sender. Button.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnSaveClick(object sender, EventArgs e)
        {
            UserSettingsFunctions settingsFunctions = new UserSettingsFunctions();
            this.SetSelectedSettings();
            settingsFunctions.SaveUserSettings();

        }

        /// <summary>
        /// The user settings form load. On form load, it inputs previously loaded settings into controls.
        /// </summary>
        /// <param name="sender">
        /// The sender. Contains form.
        /// </param>
        /// <param name="e">
        /// The e. event arguments.
        /// </param>
        private void UserSettingsFormLoad(object sender, EventArgs e)
        {
            this.nupGender.Value = Globals.SettingsForUser.DisparityTreshold;
        }
    }
}
