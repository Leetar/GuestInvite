namespace GuestInvite
{
    partial class ContactManager
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
            this.components = new System.ComponentModel.Container();
            this.grbContacts = new System.Windows.Forms.GroupBox();
            this.btnEditContact = new System.Windows.Forms.Button();
            this.lstContacts = new System.Windows.Forms.ListView();
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemoveContact = new System.Windows.Forms.Button();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.grbContactInfo = new System.Windows.Forms.GroupBox();
            this.pnlToFill = new System.Windows.Forms.Panel();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.cbxSex = new System.Windows.Forms.ComboBox();
            this.tbxCountry = new System.Windows.Forms.TextBox();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.tbxStreet = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxApartment = new System.Windows.Forms.TextBox();
            this.tbxPostalCode = new System.Windows.Forms.TextBox();
            this.infInfos = new GuestInvite.Controls.InfoPanel();
            this.lblSex = new System.Windows.Forms.Label();
            this.btnSaveContact = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errValidationErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbContacts.SuspendLayout();
            this.grbContactInfo.SuspendLayout();
            this.pnlToFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errValidationErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // grbContacts
            // 
            this.grbContacts.Controls.Add(this.btnEditContact);
            this.grbContacts.Controls.Add(this.lstContacts);
            this.grbContacts.Controls.Add(this.btnRemoveContact);
            this.grbContacts.Controls.Add(this.btnAddContact);
            this.grbContacts.Location = new System.Drawing.Point(12, 12);
            this.grbContacts.Name = "grbContacts";
            this.grbContacts.Size = new System.Drawing.Size(428, 421);
            this.grbContacts.TabIndex = 0;
            this.grbContacts.TabStop = false;
            this.grbContacts.Text = "Manage Contacts";
            // 
            // btnEditContact
            // 
            this.btnEditContact.Location = new System.Drawing.Point(89, 16);
            this.btnEditContact.Name = "btnEditContact";
            this.btnEditContact.Size = new System.Drawing.Size(75, 23);
            this.btnEditContact.TabIndex = 3;
            this.btnEditContact.Text = "Edit Contact";
            this.btnEditContact.UseVisualStyleBackColor = true;
            this.btnEditContact.Click += new System.EventHandler(this.BtnEditContactClick);
            // 
            // lstContacts
            // 
            this.lstContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstContacts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstName,
            this.LastName,
            this.colSex,
            this.colMail});
            this.lstContacts.FullRowSelect = true;
            this.lstContacts.GridLines = true;
            this.lstContacts.Location = new System.Drawing.Point(7, 45);
            this.lstContacts.MultiSelect = false;
            this.lstContacts.Name = "lstContacts";
            this.lstContacts.Size = new System.Drawing.Size(415, 370);
            this.lstContacts.TabIndex = 2;
            this.lstContacts.UseCompatibleStateImageBehavior = false;
            this.lstContacts.View = System.Windows.Forms.View.Details;
            this.lstContacts.Click += new System.EventHandler(this.LstContactsSelectedIndexChanged);
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            this.FirstName.Width = 100;
            // 
            // LastName
            // 
            this.LastName.Text = "Last Name";
            this.LastName.Width = 100;
            // 
            // colSex
            // 
            this.colSex.Text = "Sex";
            this.colSex.Width = 80;
            // 
            // colMail
            // 
            this.colMail.Text = "E-Mail";
            this.colMail.Width = 130;
            // 
            // btnRemoveContact
            // 
            this.btnRemoveContact.Location = new System.Drawing.Point(170, 16);
            this.btnRemoveContact.Name = "btnRemoveContact";
            this.btnRemoveContact.Size = new System.Drawing.Size(82, 23);
            this.btnRemoveContact.TabIndex = 1;
            this.btnRemoveContact.Text = "Remove ";
            this.btnRemoveContact.UseVisualStyleBackColor = true;
            this.btnRemoveContact.Click += new System.EventHandler(this.BtnRemoveContactClick);
            // 
            // btnAddContact
            // 
            this.btnAddContact.Location = new System.Drawing.Point(8, 16);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(75, 23);
            this.btnAddContact.TabIndex = 0;
            this.btnAddContact.Text = "Add Contact";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.BtnAddContactClick);
            // 
            // grbContactInfo
            // 
            this.grbContactInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbContactInfo.Controls.Add(this.pnlToFill);
            this.grbContactInfo.Controls.Add(this.infInfos);
            this.grbContactInfo.Controls.Add(this.lblSex);
            this.grbContactInfo.Controls.Add(this.btnSaveContact);
            this.grbContactInfo.Controls.Add(this.label8);
            this.grbContactInfo.Controls.Add(this.label7);
            this.grbContactInfo.Controls.Add(this.label6);
            this.grbContactInfo.Controls.Add(this.label5);
            this.grbContactInfo.Controls.Add(this.label4);
            this.grbContactInfo.Controls.Add(this.label3);
            this.grbContactInfo.Controls.Add(this.label2);
            this.grbContactInfo.Controls.Add(this.label1);
            this.grbContactInfo.Location = new System.Drawing.Point(446, 12);
            this.grbContactInfo.Name = "grbContactInfo";
            this.grbContactInfo.Size = new System.Drawing.Size(240, 421);
            this.grbContactInfo.TabIndex = 1;
            this.grbContactInfo.TabStop = false;
            this.grbContactInfo.Text = "Contact Details";
            this.grbContactInfo.Visible = false;
            // 
            // pnlToFill
            // 
            this.pnlToFill.Controls.Add(this.tbxFirstName);
            this.pnlToFill.Controls.Add(this.tbxLastName);
            this.pnlToFill.Controls.Add(this.cbxSex);
            this.pnlToFill.Controls.Add(this.tbxCountry);
            this.pnlToFill.Controls.Add(this.tbxCity);
            this.pnlToFill.Controls.Add(this.tbxStreet);
            this.pnlToFill.Controls.Add(this.tbxEmail);
            this.pnlToFill.Controls.Add(this.tbxApartment);
            this.pnlToFill.Controls.Add(this.tbxPostalCode);
            this.pnlToFill.Location = new System.Drawing.Point(75, 19);
            this.pnlToFill.Name = "pnlToFill";
            this.pnlToFill.Size = new System.Drawing.Size(159, 238);
            this.pnlToFill.TabIndex = 30;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(4, 3);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(136, 20);
            this.tbxFirstName.TabIndex = 8;
            this.tbxFirstName.TextChanged += new System.EventHandler(this.TextboxesTextChanged);
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(4, 29);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(136, 20);
            this.tbxLastName.TabIndex = 9;
            this.tbxLastName.TextChanged += new System.EventHandler(this.TextboxesTextChanged);
            // 
            // cbxSex
            // 
            this.cbxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSex.FormattingEnabled = true;
            this.cbxSex.Location = new System.Drawing.Point(4, 215);
            this.cbxSex.Name = "cbxSex";
            this.cbxSex.Size = new System.Drawing.Size(136, 21);
            this.cbxSex.TabIndex = 19;
            // 
            // tbxCountry
            // 
            this.tbxCountry.Location = new System.Drawing.Point(4, 55);
            this.tbxCountry.Name = "tbxCountry";
            this.tbxCountry.Size = new System.Drawing.Size(136, 20);
            this.tbxCountry.TabIndex = 10;
            this.tbxCountry.TextChanged += new System.EventHandler(this.TextboxesTextChanged);
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(4, 81);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(136, 20);
            this.tbxCity.TabIndex = 11;
            this.tbxCity.TextChanged += new System.EventHandler(this.TextboxesTextChanged);
            // 
            // tbxStreet
            // 
            this.tbxStreet.Location = new System.Drawing.Point(4, 108);
            this.tbxStreet.Name = "tbxStreet";
            this.tbxStreet.Size = new System.Drawing.Size(136, 20);
            this.tbxStreet.TabIndex = 12;
            this.tbxStreet.TextChanged += new System.EventHandler(this.TextboxesTextChanged);
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(4, 189);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(136, 20);
            this.tbxEmail.TabIndex = 15;
            this.tbxEmail.TextChanged += new System.EventHandler(this.TextboxesTextChanged);
            // 
            // tbxApartment
            // 
            this.tbxApartment.Location = new System.Drawing.Point(4, 135);
            this.tbxApartment.Name = "tbxApartment";
            this.tbxApartment.Size = new System.Drawing.Size(136, 20);
            this.tbxApartment.TabIndex = 13;
            this.tbxApartment.TextChanged += new System.EventHandler(this.TextboxesTextChanged);
            // 
            // tbxPostalCode
            // 
            this.tbxPostalCode.Location = new System.Drawing.Point(4, 162);
            this.tbxPostalCode.Name = "tbxPostalCode";
            this.tbxPostalCode.Size = new System.Drawing.Size(136, 20);
            this.tbxPostalCode.TabIndex = 14;
            this.tbxPostalCode.TextChanged += new System.EventHandler(this.TextboxesTextChanged);
            // 
            // infInfos
            // 
            this.infInfos.Location = new System.Drawing.Point(7, 263);
            this.infInfos.Name = "infInfos";
            this.infInfos.Size = new System.Drawing.Size(227, 123);
            this.infInfos.TabIndex = 29;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(7, 240);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(25, 13);
            this.lblSex.TabIndex = 17;
            this.lblSex.Text = "Sex";
            // 
            // btnSaveContact
            // 
            this.btnSaveContact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveContact.Location = new System.Drawing.Point(160, 392);
            this.btnSaveContact.Name = "btnSaveContact";
            this.btnSaveContact.Size = new System.Drawing.Size(74, 23);
            this.btnSaveContact.TabIndex = 16;
            this.btnSaveContact.Text = "Save";
            this.btnSaveContact.UseVisualStyleBackColor = true;
            this.btnSaveContact.Click += new System.EventHandler(this.BtnSaveContactClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "E-Mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Postal code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Apartment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Street";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name";
            // 
            // errValidationErrorProvider
            // 
            this.errValidationErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errValidationErrorProvider.ContainerControl = this;
            // 
            // ContactManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 445);
            this.Controls.Add(this.grbContactInfo);
            this.Controls.Add(this.grbContacts);
            this.Name = "ContactManager";
            this.Text = "ContactManager";
            this.grbContacts.ResumeLayout(false);
            this.grbContactInfo.ResumeLayout(false);
            this.grbContactInfo.PerformLayout();
            this.pnlToFill.ResumeLayout(false);
            this.pnlToFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errValidationErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbContacts;
        private System.Windows.Forms.Button btnRemoveContact;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.GroupBox grbContactInfo;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxPostalCode;
        private System.Windows.Forms.TextBox tbxApartment;
        private System.Windows.Forms.TextBox tbxStreet;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.TextBox tbxCountry;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstContacts;
        private System.Windows.Forms.Button btnEditContact;
        private System.Windows.Forms.Button btnSaveContact;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ComboBox cbxSex;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.ColumnHeader colSex;
        private System.Windows.Forms.ColumnHeader colMail;
        private System.Windows.Forms.ErrorProvider errValidationErrorProvider;
        private Controls.InfoPanel infInfos;
        private System.Windows.Forms.Panel pnlToFill;
    }
}