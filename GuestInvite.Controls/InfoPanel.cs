using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuestInvite.Controls
{
    public partial class InfoPanel : UserControl
    {
        private enum MyEnum
        {

        }
        private Point location = new Point();

        public InfoPanel()
        {
            this.InitializeComponent();
            this.location.X = 0;
            this.location.Y = 0;
        }

        public void AddErrors(Dictionary<string, Color> problems)
        {
            Label errorLabel;
            int repetition = 0;

            foreach (KeyValuePair<string, Color> problem in problems)
            {
                errorLabel = new Label() { Text = problem.Key, ForeColor = problem.Value, Width = this.Width};
                errorLabel.Location = this.SumLocation(repetition, errorLabel.Height);
                this.Controls.Add(errorLabel);
                repetition++;
            }
        }

        private Point SumLocation(int repetition, int controlHeight)
        {
            Point tempLocaton = new Point() { X = 0, Y = controlHeight * repetition };
            this.location = tempLocaton;
            return tempLocaton;
        }

        public void ResetErrors()
        {
            this.Controls.Clear();
        }
    }
}
