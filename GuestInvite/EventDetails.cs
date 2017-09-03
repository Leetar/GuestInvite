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
    using GuestInvite.Data;
    using GuestInvite.Functions;

    public partial class EventDetails : Form
    {
        public EventDetails()
        {
            this.InitializeComponent();
            this.BindContacts();
        }

        public EventDetails(GuestInvite.Data.Event editedEvent)
        {

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

        private void SetDisparityWarning()
        {

        }

        private void BtnSaveClick(object sender, EventArgs e)
        {
            Event eventToSave = new Event();
            eventToSave.Description = this.tbxEventDescription.Text;
            eventToSave.Name = this.tbxEventName.Text;
            eventToSave.InvitedGuests = this.movableItemsListView1.GetSelectedContacts();
            eventToSave.EventDate = this.dtpEventDate.Value.Date + this.dtpEventTime.Value.TimeOfDay;
        }

        private void MovableItemsListView1ItemMoved(object sender, EventArgs e)
        {
            Event eventSoFar = this.GetEventSoFar();
            Tuple<int, Contact.Genders> disparity = eventSoFar.GetSexDisparity();
        }
    }
}
