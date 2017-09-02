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

    using GuestInvite.Data;

    public partial class ErrorPanel : UserControl
    {
        private Point location = new Point();

        public ErrorPanel()
        {
            this.InitializeComponent();
            this.location.X = 0;
            this.location.Y = 0;
        }

        public void AddError(Color errorColor, string message)
        {
            Label errorLabel = new Label
            {
                Text = message,
                ForeColor = errorColor,
            };
            errorLabel.Location = this.location.Y == 0 ? this.location : this.SumLocation(errorLabel.Height);
            this.Controls.Add(errorLabel);
        }

        private Point SumLocation(int y, int x = 0)
        {
            Point tempLocaton = new Point() { X = this.location.X += x, Y = this.location.Y += y };
            this.location = tempLocaton;
            return tempLocaton;
        }
    }
}
