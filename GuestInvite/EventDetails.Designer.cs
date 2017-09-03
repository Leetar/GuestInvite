namespace GuestInvite.UI
{
    partial class EventDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tbxEventName = new System.Windows.Forms.TextBox();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.tbxEventDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpEventTime = new System.Windows.Forms.DateTimePicker();
            this.lblDisparity = new System.Windows.Forms.Label();
            this.movableItemsListView1 = new GuestInvite.Controls.MovableItemsListView();
            this.SuspendLayout();
            // 
            // tbxEventName
            // 
            this.tbxEventName.Location = new System.Drawing.Point(108, 15);
            this.tbxEventName.Name = "tbxEventName";
            this.tbxEventName.Size = new System.Drawing.Size(248, 20);
            this.tbxEventName.TabIndex = 0;
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.Location = new System.Drawing.Point(108, 42);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(138, 20);
            this.dtpEventDate.TabIndex = 1;
            // 
            // tbxEventDescription
            // 
            this.tbxEventDescription.Location = new System.Drawing.Point(108, 69);
            this.tbxEventDescription.Multiline = true;
            this.tbxEventDescription.Name = "tbxEventDescription";
            this.tbxEventDescription.Size = new System.Drawing.Size(248, 325);
            this.tbxEventDescription.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 399);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save Event";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Contacts to Chose";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(668, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chosen Contacts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Time:";
            // 
            // dtpEventTime
            // 
            this.dtpEventTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEventTime.Location = new System.Drawing.Point(291, 42);
            this.dtpEventTime.Name = "dtpEventTime";
            this.dtpEventTime.Size = new System.Drawing.Size(65, 20);
            this.dtpEventTime.TabIndex = 11;
            // 
            // lblDisparity
            // 
            this.lblDisparity.AutoSize = true;
            this.lblDisparity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDisparity.ForeColor = System.Drawing.Color.Red;
            this.lblDisparity.Location = new System.Drawing.Point(108, 406);
            this.lblDisparity.Name = "lblDisparity";
            this.lblDisparity.Size = new System.Drawing.Size(51, 16);
            this.lblDisparity.TabIndex = 12;
            this.lblDisparity.Text = "label7";
            this.lblDisparity.Visible = false;
            // 
            // movableItemsListView1
            // 
            this.movableItemsListView1.AllContacts = null;
            this.movableItemsListView1.Location = new System.Drawing.Point(389, 42);
            this.movableItemsListView1.Name = "movableItemsListView1";
            this.movableItemsListView1.Size = new System.Drawing.Size(499, 380);
            this.movableItemsListView1.TabIndex = 3;
            this.movableItemsListView1.ItemMoved += new System.EventHandler(this.MovableItemsListView1ItemMoved);
            // 
            // EventDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 428);
            this.Controls.Add(this.lblDisparity);
            this.Controls.Add(this.dtpEventTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.movableItemsListView1);
            this.Controls.Add(this.tbxEventDescription);
            this.Controls.Add(this.dtpEventDate);
            this.Controls.Add(this.tbxEventName);
            this.Name = "EventDetails";
            this.Text = "EventDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxEventName;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.TextBox tbxEventDescription;
        private Controls.MovableItemsListView movableItemsListView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpEventTime;
        private System.Windows.Forms.Label lblDisparity;
    }
}