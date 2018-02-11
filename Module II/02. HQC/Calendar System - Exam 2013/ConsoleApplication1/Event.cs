using System;

namespace CalendarSystem
{
    public class Event : IComparable<Event>
    {
        public const string DateFormat = "yyyy-MM-ddTHH:mm:ss";

        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }

        public override string ToString()
        {
            string eventToPrint = "{0:" + DateFormat + "} | {1}";
            if (this.Location != null)
            {
                eventToPrint += " | {2}";
            }

            string eventAsString = string.Format(eventToPrint, this.Date, this.Title, this.Location);
            return eventAsString;
        }
        public int CompareTo(Event other)
        {
            int result = this.Date.CompareTo(other.Date);

            if(result == 0)
            {
                result = this.Title.ToLower().CompareTo(other.Title.ToLower());
            }
            if(result == 0)
            {
                result = this.Location.ToLower().CompareTo(other.Location.ToLower());
            }
            return result;
        }
    }
}
