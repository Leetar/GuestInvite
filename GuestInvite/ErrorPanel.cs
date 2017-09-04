// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ErrorPanel.cs" company="Adam Litarowicz">
//   a
// </copyright>
// <summary>
//   Defines the ErrorPanel type. Control to display info messages.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GuestInvite.UI
{
    using System.Drawing;
    using System.Windows.Forms;

    /// <inheritdoc />
    /// <summary>
    /// The error panel. Control to display info messages.
    /// </summary>
    public partial class ErrorPanel : UserControl
    {
        private Point location = new Point();

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:GuestInvite.UI.ErrorPanel" /> class. Sets initial location for labels with messages.
        /// </summary>
        public ErrorPanel()
        {
            this.InitializeComponent();
            this.location.X = 0;
            this.location.Y = 0;
        }

        /// <summary>
        /// The add error. Adds message to panel.
        /// </summary>
        /// <param name="errorColor">
        /// The error color.
        /// </param>
        /// <param name="message">
        /// The message.
        /// </param>
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

        /// <summary>
        /// The sum location. Sets new location for label.
        /// </summary>
        /// <param name="y">
        /// The y.
        /// </param>
        /// <param name="x">
        /// The x.
        /// </param>
        /// <returns>
        /// The <see cref="Point"/>.
        /// </returns>
        private Point SumLocation(int y, int x = 0)
        {
            Point tempLocaton = new Point() { X = this.location.X += x, Y = this.location.Y += y };
            this.location = tempLocaton;
            return tempLocaton;
        }
    }
}
