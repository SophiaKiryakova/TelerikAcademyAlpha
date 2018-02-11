using System;
using System.Collections.Generic;
using System.Linq;

namespace CalendarSystem
{
    public class EventsManager : IEventsManager
    {
        private readonly List<Event> list = new List<Event>();
        public void AddEvent(Event eventToAdd)
        {
            if(eventToAdd == null)
            {
                throw new ArgumentNullException("Event cannot be null!");
            }
            this.list.Add(eventToAdd);
        }

        public int DeleteEventsByTitle(string titleEvent)
        {
            if(titleEvent == null)
            {
                throw new ArgumentNullException("Event title cannot be null!");
            }
            return this.list.RemoveAll(eventTitle => eventTitle.Title.ToLowerInvariant() == titleEvent.ToLowerInvariant());
        }

        public IEnumerable<Event> ListEvents(DateTime date, int count)
        {
            return this.list
                .Where(currentEvent => currentEvent.Date >= date)
                .Take(count);
        }
    }
}