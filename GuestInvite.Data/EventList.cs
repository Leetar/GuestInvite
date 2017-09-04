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
    using System.Linq;

    public class EventList : List<Event>
    {
        public void Replace(Event eventToReplace, Event replacingEvent)
        {
            foreach (Event @event in this)
            {
                if (@event.Id != eventToReplace.Id)
                {
                    continue;
                }

                this[this.IndexOf(@event)] = replacingEvent;
                break;
            }
        }

        public new void Remove(Event @event)
        {
            foreach (Event ev in this)
            {
                if (ev.Id == @event.Id)
                {
                    base.Remove(ev);
                    break;
                }
            }
        }
    }
}
