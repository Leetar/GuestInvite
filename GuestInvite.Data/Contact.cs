﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Class1.cs" company="Me">
//   Adam Litarowicz
// </copyright>
// <summary>
//   Defines the Class1 type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GuestInvite.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Contact
    {
        public Contact()
        {
            this.Id = Guid.NewGuid();
        }

        public enum Genders
        {
            Unspecified = 0,
            Male = 1,
            Female = 2
        }

        public enum Responses
        {
            Accepted,
            Rejected,
            Maybe,
            None
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

        public bool HasResponded { get; set; }

        public Responses Response { get; set; }

        public Guid Id { get; set; }
    }
}
