namespace GuestInvite.UI
{
    partial class EventManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstEvents = new System.Windows.Forms.ListView();
            this.colEventName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGuestsInvited = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNumResponded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSexDisparity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEventRemove = new System.Windows.Forms.Button();
            this.btnEventEdit = new System.Windows.Forms.Button();
            this.btnEventAdd = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbEventDetails = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colGuest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResponse = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbEventDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstEvents
            // 
            this.lstEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEventName,
            this.colDate,
            this.colGuestsInvited,
            this.colNumResponded,
            this.colSexDisparity});
            this.lstEvents.GridLines = true;
            this.lstEvents.Location = new System.Drawing.Point(100, 19);
            this.lstEvents.MultiSelect = false;
            this.lstEvents.Name = "lstEvents";
            this.lstEvents.Size = new System.Drawing.Size(431, 488);
            this.lstEvents.TabIndex = 3;
            this.lstEvents.UseCompatibleStateImageBehavior = false;
            this.lstEvents.View = System.Windows.Forms.View.Details;
            // 
            // colEventName
            // 
            this.colEventName.Text = "Event Name";
            this.colEventName.Width = 80;
            // 
            // colDate
            // 
            this.colDate.Text = "Event Date";
            this.colDate.Width = 96;
            // 
            // colGuestsInvited
            // 
            this.colGuestsInvited.Text = "# Invited";
            // 
            // colNumResponded
            // 
            this.colNumResponded.Text = "# Responded";
            this.colNumResponded.Width = 83;
            // 
            // colSexDisparity
            // 
            this.colSexDisparity.Text = "Sex Disparity";
            this.colSexDisparity.Width = 106;
            // 
            // btnEventRemove
            // 
            this.btnEventRemove.Location = new System.Drawing.Point(6, 77);
            this.btnEventRemove.Name = "btnEventRemove";
            this.btnEventRemove.Size = new System.Drawing.Size(88, 23);
            this.btnEventRemove.TabIndex = 2;
            this.btnEventRemove.Text = "Remove Event";
            this.btnEventRemove.UseVisualStyleBackColor = true;
            // 
            // btnEventEdit
            // 
            this.btnEventEdit.Location = new System.Drawing.Point(6, 48);
            this.btnEventEdit.Name = "btnEventEdit";
            this.btnEventEdit.Size = new System.Drawing.Size(88, 23);
            this.btnEventEdit.TabIndex = 1;
            this.btnEventEdit.Text = "Edit Event";
            this.btnEventEdit.UseVisualStyleBackColor = true;
            // 
            // btnEventAdd
            // 
            this.btnEventAdd.Location = new System.Drawing.Point(6, 19);
            this.btnEventAdd.Name = "btnEventAdd";
            this.btnEventAdd.Size = new System.Drawing.Size(88, 23);
            this.btnEventAdd.TabIndex = 0;
            this.btnEventAdd.Text = "Add Event";
            this.btnEventAdd.UseVisualStyleBackColor = true;
            this.btnEventAdd.Click += new System.EventHandler(this.BtnEventAddClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageContactsToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(924, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageContactsToolStripMenuItem
            // 
            this.manageContactsToolStripMenuItem.Name = "manageContactsToolStripMenuItem";
            this.manageContactsToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.manageContactsToolStripMenuItem.Text = "Manage Contacts";
            this.manageContactsToolStripMenuItem.Click += new System.EventHandler(this.ContactManagerClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstEvents);
            this.groupBox1.Controls.Add(this.btnEventAdd);
            this.groupBox1.Controls.Add(this.btnEventEdit);
            this.groupBox1.Controls.Add(this.btnEventRemove);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 513);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // grbEventDetails
            // 
            this.grbEventDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbEventDetails.Controls.Add(this.dataGridView1);
            this.grbEventDetails.Location = new System.Drawing.Point(555, 27);
            this.grbEventDetails.Name = "grbEventDetails";
            this.grbEventDetails.Size = new System.Drawing.Size(357, 513);
            this.grbEventDetails.TabIndex = 5;
            this.grbEventDetails.TabStop = false;
            this.grbEventDetails.Text = "groupBox2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGuest,
            this.colSex,
            this.colResponse});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 488);
            this.dataGridView1.TabIndex = 0;
            // 
            // colGuest
            // 
            this.colGuest.HeaderText = "Guest";
            this.colGuest.Name = "colGuest";
            this.colGuest.ReadOnly = true;
            // 
            // colSex
            // 
            this.colSex.HeaderText = "Gender";
            this.colSex.Name = "colSex";
            this.colSex.ReadOnly = true;
            // 
            // colResponse
            // 
            this.colResponse.HeaderText = "Response";
            this.colResponse.Name = "colResponse";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItemClick);
            // 
            // EventManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 546);
            this.Controls.Add(this.grbEventDetails);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EventManager";
            this.Text = "Event Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grbEventDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEventRemove;
        private System.Windows.Forms.Button btnEventEdit;
        private System.Windows.Forms.Button btnEventAdd;
        private System.Windows.Forms.ListView lstEvents;
        private System.Windows.Forms.ColumnHeader colEventName;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageContactsToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader colGuestsInvited;
        private System.Windows.Forms.ColumnHeader colNumResponded;
        private System.Windows.Forms.ColumnHeader colSexDisparity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grbEventDetails;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGuest;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewComboBoxColumn colResponse;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}