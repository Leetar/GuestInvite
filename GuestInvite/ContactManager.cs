﻿namespace GuestInvite
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
    using GuestInvite.Functions;

    public partial class ContactManager : Form
    {
        private readonly FormValidationFunctions validationProvider;

        public ContactManager()
        {
            this.InitializeComponent();
            this.cbxSex.DataSource = Enum.GetValues(typeof(Contact.Genders));
            this.PopulateContactsList();
            this.SetRequiredControls();
            this.validationProvider = new FormValidationFunctions(this.RequiredControls);

        }

        private List<Control> RequiredControls { get; set; } = new List<Control>();

        private void SetRequiredControls()
        {
            this.RequiredControls.Add(this.tbxFirstName);
            this.RequiredControls.Add(this.tbxLastName);
            this.RequiredControls.Add(this.tbxEmail);
        }

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

        private void BtnAddContactClick(object sender, EventArgs e)
        {
            this.ClearAllContactDetailsControls();
            this.EnableAllContactDetailsControls();
            this.grbContactInfo.Visible = true;
        }

        private void BtnSaveContactClick(object sender, EventArgs e)
        {
            this.RemoveFocusFromDetailControls();

            Contact contactToSave = this.PrepareContactToSave();

            if (!this.validationProvider.AreRequiredFieldsFilled(ref this.grbContactInfo))
            {
                this.validationProvider.ShowEmptyRequiredFields(ref this.grbContactInfo, ref this.errValidationErrorProvider);
                MessageBox.Show("Not All Required Fields has been Filled!");
            }



            //if (this.btnSaveContact.Tag != null)
            //{
            //    this.SaveContactEdited(contactToSave);
            //}
            //else
            //{
            //    this.SaveContactNew(contactToSave);
            //}

            Functions.SerializationFunctions.SerializeContacts();
            this.PopulateContactsList();
        }

        private void RemoveFocusFromDetailControls()
        {
            this.ActiveControl = null;
        }

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
                Sex = (Contact.Genders)this.cbxSex.SelectedItem
            };

            return preparedContact;
        }

        private void SaveContactEdited(Contact editedContact)
        {
            Globals.ContactsInSystem.Replace(contactToReplace: (Contact)this.btnSaveContact.Tag, ReplacingContact: editedContact);

            this.btnSaveContact.Tag = null;

            this.PopulateContactsList();
        }

        private void SaveContactNew(Contact contactToSave)
        {
            this.lstContacts.SelectedItems.Clear();
            GuestInvite.Functions.ContactFunctions.AddContact(contactToSave);
            this.PopulateContactsList();

            this.grbContactInfo.Visible = false;
        }


        private void BtnEditContactClick(object sender, EventArgs e)
        {
            this.EnableAllContactDetailsControls();
            Contact selectedContact = new Contact();

            this.grbContactInfo.Visible = true;

            foreach (ListViewItem selectedItem in this.lstContacts.SelectedItems)
            {
                selectedContact = (Contact)selectedItem.Tag;
            }

            this.btnSaveContact.Tag = selectedContact;
            this.PopulateContactDetails(selectedContact);
        }

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
            this.cbxSex.SelectedItem = (object)contact.Sex;
        }

        private void TbxEmailValidating(object sender, CancelEventArgs e)
        {
            Dictionary<string, Color> problems = new Dictionary<string, Color>();

            problems = this.validationProvider.GetContactDetailsProblems(ref this.grbContactInfo);
            this.infInfos.ResetErrors();
            this.infInfos.AddErrors(problems);
        }

        private void LstContactsSelectedIndexChanged(object sender, EventArgs e)
        {
            this.ClearAllContactDetailsControls();
            this.ShowSelectedContactDetails();
            this.DisableAllContactDetailsControls();
            this.validationProvider.ShowEmptyRequiredFields(ref this.grbContactInfo, ref this.errValidationErrorProvider);

            if (this.validationProvider.IsContactDetailsContainingErrors(ref this.grbContactInfo))
            {
                //this.validationProvider.ShowValidationInfo();
            }


            this.grbContactInfo.Visible = true;
        }

        private void ClearAllContactDetailsControls()
        {
            foreach (Control control in this.grbContactInfo.Controls)
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

        private void ShowSelectedContactDetails()
        {
            Contact selectedContact = new Contact();
            selectedContact = (Contact)this.lstContacts.SelectedItems[0].Tag;
            this.PopulateContactDetails(selectedContact);

        }

        private void DisableAllContactDetailsControls()
        {
            foreach (Control control in this.grbContactInfo.Controls)
            {
                control.Enabled = false;
            }
        }

        private void EnableAllContactDetailsControls()
        {
            foreach (Control control in this.grbContactInfo.Controls)
            {
                control.Enabled = true;
            }
        }

        private void TextboxesTextChanged(object sender, EventArgs e)
        {
            Dictionary<string, Color> problems = new Dictionary<string, Color>();
            problems = this.validationProvider.GetContactDetailsProblems(ref this.grbContactInfo);
            this.infInfos.AddErrors(problems);
            this.validationProvider.ShowEmptyRequiredFields(ref this.grbContactInfo, ref this.errValidationErrorProvider);
        }
    }
}