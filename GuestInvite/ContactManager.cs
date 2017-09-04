namespace GuestInvite
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    using GuestInvite.Data;
    using GuestInvite.Functions;

    /// <inheritdoc />
    /// <summary>
    /// The contact manager. Form to manage contacts - add, edit and remove them.
    /// </summary>
    public partial class ContactManager : Form
    {
        private readonly FormValidationFunctions validationProvider;

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:GuestInvite.ContactManager" /> class. Performs initial population of contacts and controls.
        /// </summary>
        public ContactManager()
        {
            this.InitializeComponent();
            this.cbxSex.DataSource = Enum.GetValues(typeof(Contact.Genders));
            this.PopulateContactsList();
            this.SetRequiredControls();
            this.validationProvider = new FormValidationFunctions(this.RequiredControls);
        }

        /// <summary>
        /// Gets or sets the required controls. Contains controls that are required to be filled by the user in order to be able to save the contact.
        /// </summary>
        private List<Control> RequiredControls { get; set; } = new List<Control>();

        /// <summary>
        /// The close form closing. Performs serialization of contacts when user closes the form
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void CloseFormClosing(object sender, FormClosingEventArgs e)
        {
            Functions.SerializationFunctions.SerializeContacts();
        }

        /// <summary>
        /// The set required controls. Sets controls that are required to be filled by the user.
        /// </summary>
        private void SetRequiredControls()
        {
            this.RequiredControls.Add(this.tbxFirstName);
            this.RequiredControls.Add(this.tbxLastName);
            this.RequiredControls.Add(this.tbxEmail);
        }

        /// <summary>
        /// The populate contacts list. populates contact list with users contacts.
        /// </summary>
        private void PopulateContactsList()
        {
            this.lstContacts.Items.Clear();

            if (Globals.ContactsInSystem == null)
            {
                return;
            }

            foreach (Contact contact in Globals.ContactsInSystem)
            {
                ListViewItem contactToDisplay = new ListViewItem(new[] { contact.FirlstName, contact.LastName, contact.Sex.ToString(), contact.Email })
                {
                    Tag = contact
                };

                this.lstContacts.Items.Add(contactToDisplay);
            }
        }

        /// <summary>
        /// The add contact click.prepares form for creation of new contact.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnAddContactClick(object sender, EventArgs e)
        {
            this.ClearAllContactDetailsControls();
            this.EnableAllContactDetailsControls();
            this.grbContactInfo.Visible = true;
        }

        /// <summary>
        /// The save contact click. Saves contact and serializes it. Refreshes contacts list to include new contact. Disables contact detail controls.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnSaveContactClick(object sender, EventArgs e)
        {
            if (this.validationProvider.IsContactDetailsContainingErrors(ref this.grbContactInfo))
            {
                MessageBox.Show("Cannot save. Please correct errors");
                return;
            }

            Contact contactToSave = this.PrepareContactToSave();

            if (this.btnSaveContact.Tag != null)
            {
                this.SaveContactEdited(contactToSave);
            }
            else
            {
                this.SaveContactNew(contactToSave);
            }

            SerializationFunctions.SerializeContacts();
            this.PopulateContactsList();
            this.DisableAllContactDetailsControls();
        }

        /// <summary>
        /// The prepare contact to save. Creates contact and populates it with data set by user.
        /// Later, is used to be added to list of all contacts.
        /// </summary>
        /// <returns>
        /// The <see cref="Contact"/>.
        /// </returns>
        private Contact PrepareContactToSave()
        {
            Contact preparedContact = new Contact()
            {
                Apartment = this.tbxApartment.Text,
                City = this.tbxCity.Text,
                Country = this.tbxCountry.Text,
                Email = this.tbxEmail.Text,
                FirlstName = this.tbxFirstName.Text,
                LastName = this.tbxLastName.Text,
                PostalCode = this.tbxPostalCode.Text,
                Street = this.tbxStreet.Text,
                Sex = (Contact.Genders)this.cbxSex.SelectedItem,
                Response = Contact.Responses.None
            };

            return preparedContact;
        }

        /// <summary>
        /// The save contact edited. Saves editions to an existing contact.
        /// </summary>
        /// <param name="editedContact">
        /// The edited contact.
        /// </param>
        private void SaveContactEdited(Contact editedContact)
        {
            Globals.ContactsInSystem.Replace(contactToReplace: (Contact)this.btnSaveContact.Tag, replacingContact: editedContact);

            this.btnSaveContact.Tag = null;

            this.PopulateContactsList();
        }

        /// <summary>
        /// The save contact new. Save contact that is new (i.e. is not an already existing contact in process of edition)
        /// </summary>
        /// <param name="contactToSave">
        /// The contact to save. contact that is to be saved.
        /// </param>
        private void SaveContactNew(Contact contactToSave)
        {
            this.lstContacts.SelectedItems.Clear();
            ContactFunctions.AddContact(contactToSave);
            this.PopulateContactsList();

            this.grbContactInfo.Visible = false;
        }

        /// <summary>
        /// The edit contact click. Handles editing of existing contact. Enables control for edition.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnEditContactClick(object sender, EventArgs e)
        {
            if (this.lstContacts.SelectedItems.Count == 0)
            {
                return;
            }

            this.EnableAllContactDetailsControls();
            Contact selectedContact = (Contact)this.lstContacts.SelectedItems[0].Tag;

            this.grbContactInfo.Visible = true;
            this.btnSaveContact.Tag = selectedContact;
            this.PopulateContactDetails(selectedContact);
            this.ShowContactDetailsProblems();
        }

        /// <summary>
        /// The populate contact details. populates contact details controls with data of said contact.
        /// </summary>
        /// <param name="contact">
        /// The contact. Contact with which information should form controls should be populated.
        /// </param>
        private void PopulateContactDetails(Contact contact)
        {
            this.tbxFirstName.Text = contact.FirlstName;
            this.tbxLastName.Text = contact.LastName;
            this.tbxCountry.Text = contact.Country;
            this.tbxCity.Text = contact.City;
            this.tbxStreet.Text = contact.Street;
            this.tbxApartment.Text = contact.Apartment;
            this.tbxPostalCode.Text = contact.PostalCode;
            this.tbxEmail.Text = contact.Email;
            this.cbxSex.SelectedItem = contact.Sex;
        }

        /// <summary>
        /// The contacts selected index changed. Handles change of selected contact and displays it's information in contact details.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void LstContactsSelectedIndexChanged(object sender, EventArgs e)
        {
            this.DisableAllContactDetailsControls();
            this.ClearAllContactDetailsControls();
            this.ShowSelectedContactDetails();

            this.grbContactInfo.Visible = true;
        }

        /// <summary>
        /// The clear all contact details controls. clears all textboxes and sets combo box to default value.
        /// </summary>
        private void ClearAllContactDetailsControls()
        {
            foreach (Control control in this.grbContactInfo.Controls["pnlToFill"].Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }

                if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = 0;
                }
            }
        }

        /// <summary>
        /// The show selected contact details. displays details of selected contact to the user.
        /// </summary>
        private void ShowSelectedContactDetails()
        {
            Contact selectedContact = (Contact)this.lstContacts.SelectedItems[0].Tag;
            this.PopulateContactDetails(selectedContact);
        }

        /// <summary>
        /// The disable all contact details controls. Changes state of all contact details control to disabled.
        /// </summary>
        private void DisableAllContactDetailsControls()
        {
            foreach (Control control in this.grbContactInfo.Controls)
            {
                control.Enabled = false;
            }
        }

        /// <summary>
        /// The enable all contact details controls. Changes state of all contact details control to enabled.
        /// </summary>
        private void EnableAllContactDetailsControls()
        {
            foreach (Control control in this.grbContactInfo.Controls)
            {
                control.Enabled = true;
            }
        }

        /// <summary>
        /// The textboxes text changed. On each change in any of the text boxes in panel containing contact details
        /// checks whether any of these text boxes contain errors and shows them to the user.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void TextboxesTextChanged(object sender, EventArgs e)
        {
            if (!((TextBox)sender).Enabled == false)
            {
                this.ShowContactDetailsProblems();
            }
        }

        /// <summary>
        /// The show contact details problems. Displays problems with contact details while editing. Adds found problems to InfoPanel control
        /// on form and displays warning icons next to problematic text fields.
        /// </summary>
        private void ShowContactDetailsProblems()
        {
            Dictionary<string, Color> problems = this.validationProvider.GetContactDetailsProblems(ref this.grbContactInfo);
            this.infInfos.ResetErrors();
            this.infInfos.AddErrors(problems);
            this.validationProvider.ShowEmptyRequiredFields(ref this.grbContactInfo, ref this.errValidationErrorProvider);

            if (!this.validationProvider.IsMailValid(ref this.grbContactInfo))
            {
                this.validationProvider.ShowInvalidMailIcon(ref this.grbContactInfo, ref this.errValidationErrorProvider);
            }
        }

        /// <summary>
        /// The button remove contact click. Removes contact from system permanently. If action cancelled, disables contact detail controls.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnRemoveContactClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to remove this contact?",
                "Confirmation",
                MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                this.DisableAllContactDetailsControls();
                this.PopulateContactDetails((Contact)this.lstContacts.SelectedItems[0].Tag);
                return;
            }

            Contact contactToRemove = (Contact)this.lstContacts.SelectedItems[0].Tag;
            Globals.ContactsInSystem.Remove(contactToRemove);
            SerializationFunctions.SerializeContacts();
            this.PopulateContactsList();
        }
    }
}
