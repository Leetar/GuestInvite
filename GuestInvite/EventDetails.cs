using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuestInvite.UI
{
    using System.Runtime.CompilerServices;

    using GuestInvite.Data;
    using GuestInvite.Functions;

    public partial class EventDetails : Form
    {
        private Event editedEvent;

        public EventDetails()
        {
            this.InitializeComponent();
            this.BindContacts();
        }

        public EventDetails(GuestInvite.Data.Event editedEvent)
        {
            editedEvent = new Event();
            this.editedEvent = editedEvent;
        }



        private void BindEditedEventDetails(GuestInvite.Data.Event editedEvent)
        {
            this.tbxEventName.Text = editedEvent.Name;
            this.tbxEventDescription.Text = editedEvent.Description;
            this.dtpEventDate.Value = editedEvent.EventDate;
            this.dtpEventTime.Value = editedEvent.EventDate;
        }

        private void BindContacts()
        {
            SerializationFunctions.DeserializeContacts();
            this.movableItemsListView1.AllContacts = Globals.ContactsInSystem;
            this.movableItemsListView1.BindLists();
        }

        private Event GetEventSoFar()
        {
            Event eventSoFar = new Event();
            eventSoFar.Description = this.tbxEventDescription.Text;
            eventSoFar.Name = this.tbxEventName.Text;
            eventSoFar.InvitedGuests = this.movableItemsListView1.GetSelectedContacts();
            eventSoFar.EventDate = this.dtpEventDate.Value.Date + this.dtpEventTime.Value.TimeOfDay;

            return eventSoFar;
        }

        private void SetDisparityWarning(Tuple<int, Contact.Genders> disparity)
        {
            if (disparity.Item1 < Globals.SettingsForUser.DisparityTreshold || disparity.Item1 == 0)
            {
                this.lblDisparity.Visible = false;
                return;
            }

            this.lblDisparity.Visible = true;
            this.lblDisparity.Text = disparity.Item1.ToString() + " more " + disparity.Item2.ToString()
                                     + "(s) than other genders";
        }

        private void BtnSaveClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tbxEventName.Text))
            {
                MessageBox.Show("Please Fill event name", "warning");
                return;
            }

            if (this.editedEvent != null)
            {
                this.saveEventEdited();
                MessageBox.Show("Saved successfully");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            this.SaveEventNew();
            MessageBox.Show("Saved successfully");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SaveEventNew()
        {
            Globals.EventsInSystem.Add(this.PrepareEventToSave());
            Functions.SerializationFunctions.SerializeEvents();
        }

        private void saveEventEdited()
        {
            Globals.EventsInSystem.Replace(this.editedEvent, this.PrepareEventToSave());
            Functions.SerializationFunctions.SerializeEvents();
        }

        private Event PrepareEventToSave()
        {
            Event eventToSave = new Event();
            eventToSave.Description = this.tbxEventDescription.Text;
            eventToSave.Name = this.tbxEventName.Text;
            eventToSave.InvitedGuests = this.movableItemsListView1.GetSelectedContacts();
            eventToSave.EventDate = this.dtpEventDate.Value.Date + this.dtpEventTime.Value.TimeOfDay;

            return eventToSave;
        }

        private void MovableItemsListView1ItemMoved(object sender, EventArgs e)
        {
            Event eventSoFar = this.GetEventSoFar();
            this.SetDisparityWarning(eventSoFar.GetSexDisparity());
        }

        private void BtnCancelClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
