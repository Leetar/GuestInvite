// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EventList.cs" company="Adam Litarowicz">
//   a
// </copyright>
// <summary>
//   Defines the EventList type. Class holding all created events.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GuestInvite.Data
{
    using System.Collections.Generic;

    public class EventList : List<Event>
    {
        public void Replace(Event eventToReplace, Event replacingEvent)
        {
            this[this.IndexOf(eventToReplace)] = replacingEvent;
        }
    }
}
