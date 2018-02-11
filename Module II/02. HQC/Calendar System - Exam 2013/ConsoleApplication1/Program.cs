using System;

namespace CalendarSystem
{
    public class Program
    {
        internal static void Main()
        {
            var eventsManager = new EventsManager();
            var eventsProcessor = new CommandProcessor(eventsManager);

            while (true)
            {
                var inputTextLine = Console.ReadLine();

                if (inputTextLine == "End" || inputTextLine == null)
                {
                    break;
                }

                try
                {
                    Console.WriteLine(eventsProcessor.ProcessCommand(Command.Parse(inputTextLine)));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}





