using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CalendarSystem
{
    public class CommandProcessor
    {
        private const string AddEventCommand = "AddEvent";
        private const string EventAddedMessage = "Event added";
        private const string DeleteEventsCommand = "DeleteEvents";
        private const string NoEventsFoundMessage = "No events found.";

        private readonly IEventsManager eventsManager;

        public CommandProcessor(IEventsManager eventsManager)
        {
            this.eventsManager = eventsManager;
        }

        public IEventsManager EventsProcessor
        {
            get
            {
                return this.eventsManager;
            }
        }
        public string ProcessCommand(Command command)
        {
            if (command.CommandName == AddEventCommand)
            {
                var date = DateTime.ParseExact(command.Parameters[0], Event.DateFormat, CultureInfo.InvariantCulture);
                if (command.Parameters.Length == 2)
                {
                    return this.ProcessAddEventCommand(date, command.Parameters[1], null);
                }
                else
                {
                    return this.ProcessAddEventCommand(date, command.Parameters[1], command.Parameters[2]);
                }
            }
            if ((command.CommandName == DeleteEventsCommand) && (command.Parameters.Length == 1))
            {
                return this.ProcessDeleteEventsCommand(command.Parameters[0]);
            }
            if ((command.CommandName == "ListEvents") && (command.Parameters.Length == 2))
            {
                var date = DateTime.ParseExact(command.Parameters[0], Event.DateFormat, CultureInfo.InvariantCulture);

                return this.ProcessListEventsCommand(date, int.Parse(command.Parameters[1]));
            }
            throw new Exception("Unknown command: " + command.CommandName);
        }

        private string ProcessListEventsCommand(DateTime date, int count)
        {
            var events = this.eventsManager.ListEvents(date, count).ToList();
            var sb = new StringBuilder();

            if (!events.Any())
            {
                return NoEventsFoundMessage;
            }

            foreach (var eventFound in events)
            {
                sb.AppendLine(eventFound.ToString());
            }
            return sb.ToString().Trim();
        }

        private string ProcessDeleteEventsCommand(string eventName)
        {
            int deletedEventsCount = this.eventsManager.DeleteEventsByTitle(eventName);

            if (deletedEventsCount == 0)
            {
                return NoEventsFoundMessage;
            }

            return deletedEventsCount + " events deleted";
        }

        private string ProcessAddEventCommand(DateTime date, string title, string location = null)
        {
            var eventToAdd = new Event
            {
                Date = date,
                Title = title,
                Location = location,
            };

            this.eventsManager.AddEvent(eventToAdd);

            return EventAddedMessage;
        }
    }
}
