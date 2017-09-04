// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Contact.cs" company="Me">
//   Adam Litarowicz
// </copyright>
// <summary>
//   Defines the Contact type. Contact represents person, which can be inserted into user created events.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GuestInvite.Data
{
    using System;

    /// <summary>
    /// The contact. Contact represents person, which can be inserted into user created events.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Contact"/> class. Sets persons unique ID.
        /// </summary>
        public Contact()
        {
            this.Id = Guid.NewGuid();
        }

        /// <summary>
        /// The genders. Contains genders.
        /// </summary>
        public enum Genders
        {
            Unspecified = 0,
            Male = 1,
            Female = 2
        }

        /// <summary>
        /// The responses. Contains responses that user can set to contact. Represents acceptance or lack thereof of invitation
        /// </summary>
        public enum Responses
        {
            Accepted = 1,
            Rejected = 2,
            Maybe = 3,
            None = 0
        }

        public string FirlstName { get; set; }

        public string LastName { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string Apartment { get; set; }

        public string PostalCode { get; set; }

        public string Email { get; set; }

        public Genders Sex { get; set; }

        public Responses Response { get; set; }

        public Guid Id { get; set; }

        public bool GetHasResponded()
        {
            if (this.Response != Responses.None)
            {
                return true;
            }

            return false;
        }
    }
}
