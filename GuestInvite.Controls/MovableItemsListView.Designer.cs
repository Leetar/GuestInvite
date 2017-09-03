namespace GuestInvite.Controls
{
    partial class MovableItemsListView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lstRight = new System.Windows.Forms.ListView();
            this.colNameRight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSexRight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstLeft = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRightAll = new System.Windows.Forms.Button();
            this.btnRightOne = new System.Windows.Forms.Button();
            this.btnLeftOne = new System.Windows.Forms.Button();
            this.btnLeftAll = new System.Windows.Forms.Button();
            this.pnlButtonsMove = new System.Windows.Forms.Panel();
            this.pnlButtonsMove.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstRight
            // 
            this.lstRight.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNameRight,
            this.colSexRight});
            this.lstRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.lstRight.FullRowSelect = true;
            this.lstRight.GridLines = true;
            this.lstRight.Location = new System.Drawing.Point(279, 0);
            this.lstRight.Name = "lstRight";
            this.lstRight.Size = new System.Drawing.Size(220, 407);
            this.lstRight.TabIndex = 3;
            this.lstRight.UseCompatibleStateImageBehavior = false;
            this.lstRight.View = System.Windows.Forms.View.Details;
            // 
            // colNameRight
            // 
            this.colNameRight.Text = "Name";
            this.colNameRight.Width = 125;
            // 
            // colSexRight
            // 
            this.colSexRight.Text = "Sex";
            // 
            // lstLeft
            // 
            this.lstLeft.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colSex});
            this.lstLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstLeft.FullRowSelect = true;
            this.lstLeft.GridLines = true;
            this.lstLeft.Location = new System.Drawing.Point(0, 0);
            this.lstLeft.MultiSelect = false;
            this.lstLeft.Name = "lstLeft";
            this.lstLeft.Size = new System.Drawing.Size(220, 407);
            this.lstLeft.TabIndex = 2;
            this.lstLeft.UseCompatibleStateImageBehavior = false;
            this.lstLeft.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 125;
            // 
            // colSex
            // 
            this.colSex.Text = "Sex";
            // 
            // btnRightAll
            // 
            this.btnRightAll.BackgroundImage = global::GuestInvite.Controls.Properties.Resources.arrowdoubleright;
            this.btnRightAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRightAll.Location = new System.Drawing.Point(19, 105);
            this.btnRightAll.Name = "btnRightAll";
            this.btnRightAll.Size = new System.Drawing.Size(45, 28);
            this.btnRightAll.TabIndex = 7;
            this.btnRightAll.UseVisualStyleBackColor = true;
            this.btnRightAll.Click += new System.EventHandler(this.BtnRightAllClick);
            // 
            // btnRightOne
            // 
            this.btnRightOne.BackgroundImage = global::GuestInvite.Controls.Properties.Resources.arrowright;
            this.btnRightOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRightOne.Location = new System.Drawing.Point(19, 71);
            this.btnRightOne.Name = "btnRightOne";
            this.btnRightOne.Size = new System.Drawing.Size(45, 28);
            this.btnRightOne.TabIndex = 6;
            this.btnRightOne.UseVisualStyleBackColor = true;
            this.btnRightOne.Click += new System.EventHandler(this.BtnRightOneClick);
            // 
            // btnLeftOne
            // 
            this.btnLeftOne.BackgroundImage = global::GuestInvite.Controls.Properties.Resources.arrowleft;
            this.btnLeftOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLeftOne.Location = new System.Drawing.Point(19, 37);
            this.btnLeftOne.Name = "btnLeftOne";
            this.btnLeftOne.Size = new System.Drawing.Size(45, 28);
            this.btnLeftOne.TabIndex = 5;
            this.btnLeftOne.UseVisualStyleBackColor = true;
            this.btnLeftOne.Click += new System.EventHandler(this.BtnLeftOneClick);
            // 
            // btnLeftAll
            // 
            this.btnLeftAll.BackgroundImage = global::GuestInvite.Controls.Properties.Resources.arrowdoubleleft;
            this.btnLeftAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLeftAll.Location = new System.Drawing.Point(19, 3);
            this.btnLeftAll.Name = "btnLeftAll";
            this.btnLeftAll.Size = new System.Drawing.Size(45, 28);
            this.btnLeftAll.TabIndex = 4;
            this.btnLeftAll.UseVisualStyleBackColor = true;
            this.btnLeftAll.Click += new System.EventHandler(this.BtnLeftAllClick);
            // 
            // pnlButtonsMove
            // 
            this.pnlButtonsMove.Controls.Add(this.btnLeftAll);
            this.pnlButtonsMove.Controls.Add(this.btnLeftOne);
            this.pnlButtonsMove.Controls.Add(this.btnRightOne);
            this.pnlButtonsMove.Controls.Add(this.btnRightAll);
            this.pnlButtonsMove.Location = new System.Drawing.Point(209, 113);
            this.pnlButtonsMove.Name = "pnlButtonsMove";
            this.pnlButtonsMove.Size = new System.Drawing.Size(81, 140);
            this.pnlButtonsMove.TabIndex = 8;
            // 
            // MovableItemsListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstLeft);
            this.Controls.Add(this.lstRight);
            this.Controls.Add(this.pnlButtonsMove);
            this.Name = "MovableItemsListView";
            this.Size = new System.Drawing.Size(499, 407);
            this.pnlButtonsMove.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstRight;
        private System.Windows.Forms.ListView lstLeft;
        private System.Windows.Forms.Button btnLeftAll;
        private System.Windows.Forms.Button btnLeftOne;
        private System.Windows.Forms.Button btnRightOne;
        private System.Windows.Forms.Button btnRightAll;
        private System.Windows.Forms.Panel pnlButtonsMove;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colSex;
        private System.Windows.Forms.ColumnHeader colNameRight;
        private System.Windows.Forms.ColumnHeader colSexRight;
    }
}
