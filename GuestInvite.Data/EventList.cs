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

    /// <inheritdoc />
    /// <summary>
    /// The event list. List holding all created events.
    /// </summary>
    public class EventList : List<Event>
    {
        /// <summary>
        /// The replace. Replaces event in list.
        /// </summary>
        /// <param name="eventToReplace">
        /// The event to replace.
        /// </param>
        /// <param name="replacingEvent">
        /// The replacing event.
        /// </param>
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

        /// <summary>
        /// The remove. Removes event from list.
        /// </summary>
        /// <param name="event">
        /// The event.
        /// </param>
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
