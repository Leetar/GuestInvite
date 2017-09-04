namespace GuestInvite.UI
{
    using System;
    using System.Windows.Forms;

    using GuestInvite.Data;
    using GuestInvite.Functions;

    public partial class EventDetails : Form
    {
        private Event editedEvent;

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:GuestInvite.UI.EventDetails" /> class. Default constructor used for new events.
        /// </summary>
        public EventDetails()
        {
            this.InitializeComponent();
            this.BindContacts();
            this.dtpEventDate.MinDate = DateTime.Now;
            this.dtpEventTime.MinDate = DateTime.Now;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:GuestInvite.UI.EventDetails" /> class. Constructor used for edited events.
        /// </summary>
        /// <param name="editedEvent">
        /// The edited event.
        /// </param>
        public EventDetails(Event editedEvent)
        {
            this.InitializeComponent();
            this.BindContacts();

            this.editedEvent = new Event();
            this.editedEvent = editedEvent;
            this.BindEditedEventDetails();
        }

        /// <summary>
        /// The bind edited event details. Binds event data to controls.
        /// </summary>
        private void BindEditedEventDetails()
        {
            this.tbxEventName.Text = this.editedEvent.Name;
            this.tbxEventDescription.Text = this.editedEvent.Description;
            this.dtpEventDate.Value = this.editedEvent.EventDate;
            this.dtpEventTime.Value = this.editedEvent.EventDate;
            this.movableItemsListView1.eventsGuestList = this.editedEvent.InvitedGuests;
            this.movableItemsListView1.BindLists();
        }

        /// <summary>
        /// The bind contacts. Binds contacts to list views.
        /// </summary>
        private void BindContacts()
        {
            SerializationFunctions.DeserializeContacts();
            this.movableItemsListView1.AllContacts = Globals.ContactsInSystem;
            this.movableItemsListView1.BindLists();
        }

        /// <summary>
        /// The get event so far. Used to get event data in it's current state.
        /// </summary>
        /// <returns>
        /// The <see cref="Event"/>.
        /// </returns>
        private Event GetEventSoFar()
        {
            Event eventSoFar = new Event();
            eventSoFar.Description = this.tbxEventDescription.Text;
            eventSoFar.Name = this.tbxEventName.Text;
            eventSoFar.InvitedGuests = this.movableItemsListView1.GetSelectedContacts();
            eventSoFar.EventDate = this.dtpEventDate.Value.Date + this.dtpEventTime.Value.TimeOfDay;

            return eventSoFar;
        }

        /// <summary>
        /// The set disparity warning. Construct string that contains warning about uneven sexes of chosen contacts.
        /// </summary>
        /// <param name="disparity">
        /// The disparity. contains numeric difference between male/female and towards which gender this difference points.
        /// </param>
        private void SetDisparityWarning(Tuple<int, Contact.Genders> disparity)
        {
            if (disparity.Item1 < Globals.SettingsForUser.DisparityTreshold || disparity.Item1 == 0)
            {
                this.lblDisparity.Visible = false;
                return;
            }

            this.lblDisparity.Visible = true;
            this.lblDisparity.Text = disparity.Item1 + " more " + disparity.Item2
                                     + "(s) than other genders";
        }

        /// <summary>
        /// The save click. Save button event. Handles saving of event.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnSaveClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tbxEventName.Text))
            {
                MessageBox.Show("Please Fill event name", "warning");
                return;
            }

            if (this.editedEvent != null)
            {
                this.SaveEventEdited();
                MessageBox.Show("Saved successfully");
                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }

            this.SaveEventNew();
            MessageBox.Show("Saved successfully");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// The save event new. Saves new event and serializes it.
        /// </summary>
        private void SaveEventNew()
        {
            Globals.EventsInSystem.Add(this.PrepareEventToSave());
            Functions.SerializationFunctions.SerializeEvents();
        }

        /// <summary>
        /// The save event edited. Saves edited event and serializes it.
        /// </summary>
        private void SaveEventEdited()
        {
            Globals.EventsInSystem.Replace(this.editedEvent, this.PrepareEventToSave());
            Functions.SerializationFunctions.SerializeEvents();
        }

        /// <summary>
        /// The prepare event to save. creates Event type and assigns user set details to it.
        /// </summary>
        /// <returns>
        /// The <see cref="Event"/>.
        /// </returns>
        private Event PrepareEventToSave()
        {
            Event eventToSave = new Event();
            eventToSave.Description = this.tbxEventDescription.Text;
            eventToSave.Name = this.tbxEventName.Text;
            eventToSave.InvitedGuests = this.movableItemsListView1.GetSelectedContacts();
            eventToSave.EventDate = this.dtpEventDate.Value.Date + this.dtpEventTime.Value.TimeOfDay;

            return eventToSave;
        }

        /// <summary>
        /// The movable items list view 1 item moved.
        /// Handles moving contacts left/right between list boxes.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void MovableItemsListView1ItemMoved(object sender, EventArgs e)
        {
            Event eventSoFar = this.GetEventSoFar();
            this.SetDisparityWarning(eventSoFar.GetSexDisparity());
        }

        /// <summary>
        /// The cancel click. Handles cancelling of event addition.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnCancelClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
