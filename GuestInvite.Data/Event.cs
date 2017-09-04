// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Event.cs" company="Adam Litarowicz">
//   a
// </copyright>
// <summary>
//   Defines the Event type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GuestInvite.Data
{
    using System;

    public class Event
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Event"/> class. Represents user created event. Event contains it's details along with
        /// invited to said event guests (contacts).
        /// </summary>
        public Event()
        {
            this.Id = Guid.NewGuid();
        }

        /// <summary>
        /// Gets or sets the name. Represents event name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the id. Represents events unique ID.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the invited guests. represents guests invited to an event.
        /// </summary>
        public ContactsList InvitedGuests { get; set; }

        /// <summary>
        /// Gets or sets the event date. represents date and time on which event is to take place.
        /// </summary>
        public DateTime EventDate { get; set; }

        /// <summary>
        /// Gets or sets the description. Represents description of this event.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The get number of invitee responses. Gets number of guests that has responded.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int GetNumberOfInviteeResponses()
        {
            return this.InvitedGuests.FindAll(x => x.GetHasResponded() == true).Count;
        }

        /// <summary>
        /// The get sex disparity. Gets disparity between male and female contacts that have been invited.
        /// </summary>
        /// <returns>
        /// The <see cref="Tuple"/>.
        /// </returns>
        public Tuple<int, Contact.Genders> GetSexDisparity()
        {
            int male = this.InvitedGuests.FindAll(x => x.Sex == Contact.Genders.Male).Count;
            int female = this.InvitedGuests.FindAll(x => x.Sex == Contact.Genders.Female).Count;

            if (male > female)
            {
                return new Tuple<int, Contact.Genders>(male - female, Contact.Genders.Male);
            }

            return new Tuple<int, Contact.Genders>(female - male, Contact.Genders.Female);
        }
    }
}
