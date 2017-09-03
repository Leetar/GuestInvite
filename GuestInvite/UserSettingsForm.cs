namespace GuestInvite.UI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    using GuestInvite.Data;
    using GuestInvite.Functions;

    public partial class UserSettingsForm : Form
    {
        public UserSettingsForm()
        {
            this.InitializeComponent();
        }

        private void SetSelectedSettings()
        {
            UserSettings settings = new UserSettings();
            settings.DisparityTreshold = (int)this.nupGender.Value;

            Globals.SettingsForUser = settings;
        }

        private void BtnSaveClick(object sender, EventArgs e)
        {
            UserSettingsFunctions settingsFunctions = new UserSettingsFunctions();
            this.SetSelectedSettings();
            settingsFunctions.SaveUserSettings();

        }

        private void UserSettingsForm_Load(object sender, EventArgs e)
        {
            this.nupGender.Value = Globals.SettingsForUser.DisparityTreshold;
        }
    }
}
