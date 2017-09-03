namespace GuestInvite.UI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

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
                    // string custName = form.CustomerName;
                    // SaveToFile(custName);
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
    }
}
