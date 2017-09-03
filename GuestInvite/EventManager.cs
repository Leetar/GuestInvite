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

    public partial class EventManager : Form
    {
        public EventManager()
        {
            this.InitializeComponent();
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
            using (EventDetails form = new EventDetails())
            {
                DialogResult dr = form.ShowDialog();
            }
        }

        private void EventManagerLoad(object sender, EventArgs e)
        {
            this.PopulateEventsListView();
        }

        public void PopulateEventsListView()
        {
            Tuple<int, Contact.Genders> disparity;

            foreach (Event @event in Globals.EventsInSystem)
            {
                disparity = @event.GetSexDisparity();
                string disparityMessage = disparity.Item1.ToString() + " more " + disparity.Item2.ToString()
                                          + "(s) than other genders";

                ListViewItem contactToDisplay = new ListViewItem(
                    new[]
                        {
                            @event.Name, @event.EventDate.ToString(CultureInfo.InvariantCulture),
                            @event.InvitedGuests.Count.ToString(), @event.GetNumberOfInviteeResponses().ToString() + "/" + @event.InvitedGuests.Count.ToString(),
                            disparityMessage
                        });

                this.lstEvents.Items.Add(contactToDisplay);
            }
        }
    }
}
