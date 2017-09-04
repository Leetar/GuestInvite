// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FormValidationFunctions.cs" company="Adam Litarowicz">
//   a
// </copyright>
// <summary>
//   Defines the FormValidationFunctions type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GuestInvite.Functions
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    using GuestInvite.Data;

    /// <summary>
    /// The form validation functions. Provides functions to validate data.
    /// </summary>
    public class FormValidationFunctions
    {
        private readonly List<Control> requiredControls;

        /// <summary>
        /// Initializes a new instance of the <see cref="FormValidationFunctions"/> class. Sets controls required on ContactManager for validation.
        /// </summary>
        /// <param name="requiredControls">
        /// The required controls.
        /// </param>
        public FormValidationFunctions(List<Control> requiredControls)
        {
            this.requiredControls = requiredControls;
        }

        /// <summary>
        /// The are required fields filled. Checks whether all required fields has been filled by the user.
        /// </summary>
        /// <param name="groupBox">
        /// The group box. group box containing validated controls.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool AreRequiredFieldsFilled(ref GroupBox groupBox)
        {
            int controlsOk = 0;

            foreach (Control control in groupBox.Controls["pnlToFill"].Controls)
            {
                if (this.requiredControls.Contains(control))
                {
                    controlsOk += !string.IsNullOrEmpty(control.Text) ? 1 : 0;
                }
            }

            if (controlsOk == this.requiredControls.Count)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// The show empty required fields.Shows required fields that has not been filled. Shows warning icon next to erroneous text fields.
        /// </summary>
        /// <param name="groupBox">
        /// The group box. group box with controls to validate.
        /// </param>
        /// <param name="errorProvider">
        /// The error provider.
        /// </param>
        public void ShowEmptyRequiredFields(ref GroupBox groupBox, ref ErrorProvider errorProvider)
        {

            foreach (Control control in groupBox.Controls["pnlToFill"].Controls)
            {
                if (!this.requiredControls.Contains(control))
                {
                    continue;
                }

                if (control.Name != "tbxEmail" && string.IsNullOrEmpty(control.Text))
                {
                    errorProvider.SetError(control, "Data wrong or not submitted.");
                }
                else
                {
                    errorProvider.SetError(control, string.Empty);
                }
            }
        }

        /// <summary>
        /// The show invalid mail icon. Shows icon next to erroneous textbox for email warning user about error.
        /// </summary>
        /// <param name="groupBox">
        /// The group box. Group box with controls to validate.
        /// </param>
        /// <param name="errorProvider">
        /// The error provider.
        /// </param>
        public void ShowInvalidMailIcon(ref GroupBox groupBox, ref ErrorProvider errorProvider)
        {
            errorProvider.SetError(groupBox.Controls["pnlToFill"].Controls["tbxEmail"], "Not a valid email address");
        }

        /// <summary>
        /// The is contact details containing errors. Checks if contact details controls contain any errors.
        /// </summary>
        /// <param name="groupBox">
        /// The group box. Group box with controls to validate.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool IsContactDetailsContainingErrors(ref GroupBox groupBox)
        {
            if (this.IsMailValid(ref groupBox) && this.AreRequiredFieldsFilled(ref groupBox))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// The is mail valid. Checks whether entered e-mail address is valid.
        /// </summary>
        /// <param name="groupBox">
        /// The group box. Group box with controls to validate.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool IsMailValid(ref GroupBox groupBox)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(groupBox.Controls["pnlToFill"].Controls["tbxEmail"].Text);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// The get contact details problems. Gets Dictionary of problems found in contact details.
        /// </summary>
        /// <param name="groupBox">
        /// The group box. Group box with controls to validate.
        /// </param>
        /// <returns>
        /// The <see cref="Dictionary"/>.
        /// </returns>
        public Dictionary<string, Color> GetContactDetailsProblems(ref GroupBox groupBox)
        {
            Dictionary<string, Color> problems = new Dictionary<string, Color>();

            if (!this.IsMailValid(ref groupBox))
            {
                problems.Add("E-mail address is not valid", this.DetermineInfoColor(ValidationEnums.ValidationInfoTypes.Error));
            }

            if (!this.AreRequiredFieldsFilled(ref groupBox))
            {
                problems.Add("Not all required fields are filled", this.DetermineInfoColor(ValidationEnums.ValidationInfoTypes.Error));
            }

            if (!this.AreOptionalFieldsFilled(ref groupBox))
            {
                problems.Add("Not all optional fields has been filled", this.DetermineInfoColor(ValidationEnums.ValidationInfoTypes.Info));
            }

            return problems;
        }

        /// <summary>
        /// The are optional fields filled. Checks if all fields that are not in the list of required fields are filled.
        /// </summary>
        /// <param name="groupBox">
        /// The group box. Group box with controls to validate.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool AreOptionalFieldsFilled(ref GroupBox groupBox)
        {
            int controlsOk = 0;

            Panel pnlToFill = new Panel();
            pnlToFill = (Panel)groupBox.Controls["pnlToFill"];

            foreach (Control control in pnlToFill.Controls)
            {
                if (!this.requiredControls.Contains(control))
                {
                    controlsOk += !string.IsNullOrEmpty(control.Text) ? 1 : 0;
                }
            }

            if (controlsOk == pnlToFill.Controls.Count - this.requiredControls.Count)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// The determine info color. Determines color of the message to be displayed.
        /// </summary>
        /// <param name="validationType">
        /// The validation type.
        /// </param>
        /// <returns>
        /// The <see cref="Color"/>.
        /// </returns>
        public Color DetermineInfoColor(ValidationEnums.ValidationInfoTypes validationType)
        {
            switch (validationType)
            {
                case ValidationEnums.ValidationInfoTypes.Error:
                    return Color.Red;
                case ValidationEnums.ValidationInfoTypes.Info:
                    return Color.Blue;
                case ValidationEnums.ValidationInfoTypes.Warning:
                    return Color.DarkOrange;
                default:
                    return Color.Black;
            }
        }
    }
}
