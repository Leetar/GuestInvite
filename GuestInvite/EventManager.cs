namespace GuestInvite.UI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
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

        private void ContactManagerClick(object sender, EventArgs e)
        {
            Form contacts = new ContactManager();
            contacts.ShowDialog();
        }

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

        private void SettingsToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (UserSettingsForm form = new UserSettingsForm())
            {
                DialogResult dr = form.ShowDialog();
                if (dr == DialogResult.OK)
                {

                }

            }
        }

        private void BtnEventEditClick(object sender, EventArgs e)
        {
            if (this.lstEvents.SelectedItems.Count == 0)
            {
                return;
            }

            using (EventDetails form = new EventDetails((Event)this.lstEvents.SelectedItems[0].Tag))
            {
                DialogResult dr = form.ShowDialog();
            }
        }

        private void EventManagerLoad(object sender, EventArgs e)
        {
            this.PopulateEventsListView();
        }

        private void PopulateEventsListView()
        {
            this.lstEvents.Items.Clear();
            Tuple<int, Contact.Genders> disparity;

            foreach (Event @event in Globals.EventsInSystem)
            {
                string disparityMessage = this.GetDisparityMessage(@event.GetSexDisparity());

                ListViewItem contactToDisplay = new ListViewItem(
                    new[]
                        {
                            @event.Name, @event.EventDate.ToString(CultureInfo.InvariantCulture),
                            @event.InvitedGuests.Count.ToString(), @event.GetNumberOfInviteeResponses().ToString() + "/" + @event.InvitedGuests.Count.ToString(),
                            disparityMessage
                        });
                contactToDisplay.Tag = @event;

                this.lstEvents.Items.Add(contactToDisplay);
            }
        }

        private string GetDisparityMessage(Tuple<int, Contact.Genders> disparity)
        {
            if (disparity.Item1 >= 0 && disparity.Item1 > Globals.SettingsForUser.DisparityTreshold)
            {
                return disparity.Item1.ToString() + " more " + disparity.Item2.ToString()
                                      + "(s) than other genders";
            }

            return string.Empty;
        }

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

        private void CbSelectedIndexChanged(object sender, EventArgs e)
        {
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
        }

        private void DtgEventDetailsEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox cb = e.Control as ComboBox;
            if (cb != null)
            {
                // first remove event handler to keep from attaching multiple:
                cb.SelectedIndexChanged -= new
                EventHandler(this.CbSelectedIndexChanged);

                // now attach the event handler
                cb.SelectedIndexChanged += new
                EventHandler(this.CbSelectedIndexChanged);
            }
        }

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
