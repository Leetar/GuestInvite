namespace GuestInvite.Functions
{
    using System;
    using System.CodeDom;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    using GuestInvite.Data;

    public class FormValidationFunctions
    {
        private readonly List<Control> requiredControls = new List<Control>();


        private int numOfErrors = 0;

        public FormValidationFunctions(List<Control> requiredControls)
        {
            this.requiredControls = requiredControls;
        }

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

        public void ShowEmptyRequiredFields(ref GroupBox groupBox, ref ErrorProvider errorProvider)
        {
            this.numOfErrors = 0;

            foreach (Control control in groupBox.Controls["pnlToFill"].Controls)
            {
                if (!this.requiredControls.Contains(control))
                {
                    continue;
                }

                if (string.IsNullOrEmpty(control.Text))
                {
                    errorProvider.SetError(control, "Data wrong or not submitted.");
                    this.numOfErrors++;
                }
                else
                {
                    errorProvider.SetError(control, string.Empty);
                }
            }
        }

        public bool IsContactDetailsContainingErrors(ref GroupBox groupBox)
        {
            int errorsNum = 0;

            foreach (Control control in groupBox.Controls)
            {
                if (!this.requiredControls.Contains(control))
                {
                    continue;
                }

                if (string.IsNullOrEmpty(control.Text))
                {
                    return true;
                }
            }

            return false;
        }

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

            if (controlsOk == this.requiredControls.Count)
            {
                return true;
            }

            return false;
        }

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
