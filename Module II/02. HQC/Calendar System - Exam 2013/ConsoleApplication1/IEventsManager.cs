using System;
using System.Collections.Generic;

namespace CalendarSystem
{
    public interface IEventsManager
    {
        void AddEvent(Event eventToAdd);
        int DeleteEventsByTitle(string titleEvent);
        IEnumerable<Event> ListEvents(DateTime date, int count);
    }
}
