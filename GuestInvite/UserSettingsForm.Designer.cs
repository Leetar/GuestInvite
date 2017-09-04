namespace GuestInvite.UI
{
    partial class UserSettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nupGender = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlSettings = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nupGender)).BeginInit();
            this.pnlSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gender Disparity Threshold";
            // 
            // nupGender
            // 
            this.nupGender.Location = new System.Drawing.Point(3, 3);
            this.nupGender.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.nupGender.Name = "nupGender";
            this.nupGender.Size = new System.Drawing.Size(120, 20);
            this.nupGender.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(243, 332);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
            // 
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.nupGender);
            this.pnlSettings.Location = new System.Drawing.Point(157, 9);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(172, 317);
            this.pnlSettings.TabIndex = 4;
            // 
            // UserSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 367);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Name = "UserSettingsForm";
            this.Text = "UserSettings";
            this.Load += new System.EventHandler(this.UserSettingsFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.nupGender)).EndInit();
            this.pnlSettings.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupGender;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlSettings;
    }
}