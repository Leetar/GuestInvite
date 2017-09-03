namespace GuestInvite.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Event
    {
        public string Name { get; set; }

        public ContactsList InvitedGuests { get; set; }

        public DateTime EventDate { get; set; }

        public string Description { get; set; }

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
