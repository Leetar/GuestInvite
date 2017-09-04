namespace GuestInvite.UI
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;

    using GuestInvite.Data;
    using GuestInvite.Functions;

    public partial class EventManager : Form
    {
        public EventManager()
        {
            this.InitializeComponent();
            this.SetColumns();
        }

        /// <summary>
        /// The set columns. Creates columns and their headers along with setting data source for combo box column.
        /// </summary>
        private void SetColumns()
        {
            DataGridViewTextBoxColumn colGuest = new DataGridViewTextBoxColumn();
            colGuest.HeaderText = "Guest";

            DataGridViewTextBoxColumn colSex = new DataGridViewTextBoxColumn();
            colSex.HeaderText = "Gender";

            DataGridViewComboBoxColumn colResponse = new DataGridViewComboBoxColumn();
            colResponse.ValueType = typeof(Contact.Responses);
            colResponse.DataSource = Enum.GetValues(typeof(Contact.Responses));
            colResponse.HeaderText = "Response";

            this.dtgEventDetails.Columns.Add(colGuest);
            this.dtgEventDetails.Columns.Add(colSex);
            this.dtgEventDetails.Columns.Add(colResponse);
        }

        /// <summary>
        /// The contact manager click. Shows contact manager form.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ContactManagerClick(object sender, EventArgs e)
        {
            Form contacts = new ContactManager();
            contacts.ShowDialog();
        }

        /// <summary>
        /// The event add click. Used to show form for event addition. and populates event list on main form with created event.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnEventAddClick(object sender, EventArgs e)
        {
            using (EventDetails form = new EventDetails())
            {
                DialogResult dr = form.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    this.PopulateEventsListView();
                }
            }
        }

        /// <summary>
        /// The settings tool strip menu item click. Opens form with user settings.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void SettingsToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (UserSettingsForm form = new UserSettingsForm())
            {
                form.ShowDialog();
            }
        }

        /// <summary>
        /// The event edit click. Opens form to edit event. Sends event selected in main form as an argument.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnEventEditClick(object sender, EventArgs e)
        {
            if (this.lstEvents.SelectedItems.Count == 0)
            {
                return;
            }

            using (EventDetails form = new EventDetails((Event)this.lstEvents.SelectedItems[0].Tag))
            {
                form.ShowDialog();
            }
        }

        /// <summary>
        /// The event manager load. Event to populate list of events on main form with existing events.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void EventManagerLoad(object sender, EventArgs e)
        {
            this.PopulateEventsListView();
        }

        /// <summary>
        /// The populate events list view. Populates event list with existing events.
        /// </summary>
        private void PopulateEventsListView()
        {
            this.lstEvents.Items.Clear();

            foreach (Event @event in Globals.EventsInSystem)
            {
                string disparityMessage = this.GetDisparityMessage(@event.GetSexDisparity());

                ListViewItem contactToDisplay = new ListViewItem(
                    new[]
                        {
                            @event.Name, @event.EventDate.ToString(CultureInfo.InvariantCulture),
                            @event.InvitedGuests.Count.ToString(), @event.GetNumberOfInviteeResponses() + "/" + @event.InvitedGuests.Count,
                            disparityMessage
                        });
                contactToDisplay.Tag = @event;

                this.lstEvents.Items.Add(contactToDisplay);
            }
        }

        /// <summary>
        /// The get disparity message. Constructs message informing of disparity of genders.
        /// </summary>
        /// <param name="disparity">
        /// The disparity. Variable containing by how many more people of a given gender than other there are and which gender it is.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        private string GetDisparityMessage(Tuple<int, Contact.Genders> disparity)
        {
            if (disparity.Item1 >= 0 && disparity.Item1 > Globals.SettingsForUser.DisparityTreshold)
            {
                return disparity.Item1.ToString() + " more " + disparity.Item2.ToString()
                                      + "(s) than other genders";
            }

            return "Disparity within set limits";
        }

        /// <summary>
        /// The events click. Handles changes on form when an item on list of events is clicked. Sets details in event details. Adds rows
        /// with said details to grid.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void LstEventsClick(object sender, EventArgs e)
        {
            this.dtgEventDetails.Rows.Clear();

            Event selectedEvent = (Event)this.lstEvents.SelectedItems[0].Tag;

            foreach (Contact contact in selectedEvent.InvitedGuests)
            {
                 DataGridViewRow row = this.dtgEventDetails.Rows.Count > 0 ? (DataGridViewRow)this.dtgEventDetails.Rows[0].Clone() : new DataGridViewRow();
                row.CreateCells(this.dtgEventDetails);

                row.Cells[0].Value = contact.FirlstName + " " + contact.LastName;
                row.Cells[1].Value = contact.Sex.ToString();
                row.Cells[2].Value = contact.Response;
                row.Cells[2].Tag = contact.Id;

                this.dtgEventDetails.Rows.Add(row);
            }
        }

        /// <summary>
        /// The selected index changed. Handles Changing of selected item in response combo box. Automatically saves response in contact details.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void CbSelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstEvents.SelectedItems.Count == 0)
            {
                return;
            }

            Event selectedEvent = (Event)this.lstEvents.SelectedItems[0].Tag;
            Guid selectedContactGuid = (Guid)this.dtgEventDetails.SelectedRows[0].Cells[2].Tag;
            DataGridViewCell selectedCell = this.dtgEventDetails.SelectedRows[0].Cells[2];

            foreach (Contact contact in selectedEvent.InvitedGuests.Where(con => con.Id == selectedContactGuid))
            {
                foreach (Contact.Responses responseType in Enum.GetValues(typeof(Contact.Responses)))
                {
                    if (responseType.ToString() == selectedCell.EditedFormattedValue.ToString())
                    {
                        contact.Response = responseType;
                        Globals.EventsInSystem.Replace((Event)this.lstEvents.SelectedItems[0].Tag, selectedEvent);
                        SerializationFunctions.SerializeEvents();
                        break;
                    }
                }
            }

            this.PopulateEventsListView();
        }

        /// <summary>
        /// The event details editing control showing. Sets event handler for responses combo box.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void DtgEventDetailsEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is ComboBox cb)
            {
                // first remove event handler to keep from attaching multiple
                cb.SelectedIndexChanged -= this.CbSelectedIndexChanged;

                // now attach the event handler
                cb.SelectedIndexChanged += this.CbSelectedIndexChanged;
            }
        }

        /// <summary>
        /// The event remove click. Removes event from events list and global variable and serializes said global variable.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnEventRemoveClick(object sender, EventArgs e)
        {
            if ((Event)this.lstEvents.SelectedItems[0].Tag == null)
            {
                return;
            }

            Event selectedEvent = (Event)this.lstEvents.SelectedItems[0].Tag;
            Globals.EventsInSystem.Remove(selectedEvent);
            SerializationFunctions.SerializeEvents();
            this.PopulateEventsListView();
        }
    }
}
