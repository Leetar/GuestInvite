namespace GuestInvite.Controls
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

    using GuestInvite.Data;

    public partial class MovableItemsListView : UserControl
    {
        private ContactsList eventsGuestList = new ContactsList();

        public MovableItemsListView()
        {
            this.InitializeComponent();
        }

        private enum ItemMoveDirection
        {
            Left,
            Right
        }

        public event EventHandler ItemMoved;

        public ContactsList AllContacts { get; set; }

        public ContactsList GetSelectedContacts()
        {
            this.eventsGuestList.Clear();

            foreach (ListViewItem item in this.lstRight.Items)
            {
                
                this.eventsGuestList.Add((Contact)item.Tag);
            }
            return this.eventsGuestList;
        }

        public void BindLists()
        {
            foreach (Contact contact in this.AllContacts)
            {
                if (this.eventsGuestList == null || !this.eventsGuestList.Contains(contact))
                {
                    ListViewItem itemLeft = new ListViewItem(new[] { contact.FirlstName + " " + contact.LastName, contact.Sex.ToString() });
                    itemLeft.Tag = contact;

                    this.lstLeft.Items.Add(itemLeft);
                    continue;
                }

                ListViewItem itemRight = new ListViewItem(new[] { contact.FirlstName + " " + contact.LastName, contact.Sex.ToString() });
                itemRight.Tag = contact;
                this.lstRight.Items.Add(itemRight);
            }
        }

        private void MoveItem(ItemMoveDirection direction, EventArgs e)
        {
            string originListView = direction == ItemMoveDirection.Left ? "lstRight" : "lstLeft";
            string destinationListView = direction == ItemMoveDirection.Left ? "lstLeft" : "lstRight";

            if (((ListView)this.Controls[originListView]).SelectedItems.Count < 1)
            {
                this.ItemMoved?.Invoke(this, e);
                return;
            }

            ListViewItem itemToMove = ((ListView)this.Controls[originListView]).SelectedItems[0];
            ((ListView)this.Controls[originListView]).Items.Remove(itemToMove);
            ((ListView)this.Controls[destinationListView]).Items.Add(itemToMove);
            this.ItemMoved?.Invoke(this, e);
        }

        private void MoveItemsAll(ItemMoveDirection direction, EventArgs e)
        {
            string originListView = direction == ItemMoveDirection.Left ? "lstRight" : "lstLeft";
            string destinationListView = direction == ItemMoveDirection.Left ? "lstLeft" : "lstRight";

            foreach (ListViewItem itemToMove in ((ListView)this.Controls[originListView]).Items)
            {
                ((ListView)this.Controls[originListView]).Items.Remove(itemToMove);
                ((ListView)this.Controls[destinationListView]).Items.Add(itemToMove);
            }
            this.ItemMoved?.Invoke(this, e);
        }

        /// <summary>
        /// The set button images. Sets buttons sizes so they fit in buttons. Fired then form loads.
        /// </summary>
        private void SetButtonImages()
        {
            foreach (Control control in this.pnlButtonsMove.Controls)
            {
                ((Button)control).BackgroundImage = (Image)(new Bitmap(((Button)control).BackgroundImage, new Size(27, 17)));
            }
        }

        private void BtnLeftOneClick(object sender, EventArgs e)
        {
            this.MoveItem(ItemMoveDirection.Left, e);
        }

        private void BtnRightOneClick(object sender, EventArgs e)
        {
            this.MoveItem(ItemMoveDirection.Right, e);
        }

        private void BtnLeftAllClick(object sender, EventArgs e)
        {
            this.MoveItemsAll(ItemMoveDirection.Left, e);
        }

        private void BtnRightAllClick(object sender, EventArgs e)
        {
            this.MoveItemsAll(ItemMoveDirection.Right, e);
        }
    }
}
