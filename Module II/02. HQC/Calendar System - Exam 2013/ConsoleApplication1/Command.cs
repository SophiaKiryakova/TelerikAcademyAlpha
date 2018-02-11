using System;

namespace CalendarSystem
{
    public struct Command
    {
        public string CommandName { get; set; }
        public string[] Parameters { get; set; }
        public static Command Parse(string commandLine)
        {
            if(commandLine == null)
            {
                throw new ArgumentNullException("Command line cannot be null!");
            }
            int indexOfSpace = commandLine.IndexOf(' ');
            if (indexOfSpace == -1)
            {
                throw new ArgumentException("Invalid command: " + commandLine);
            }

            var nameCommand = commandLine.Substring(0, indexOfSpace);
            var arguments = commandLine.Substring(indexOfSpace + 1);
            var commandArguments = arguments.Split('|');

            for (int i = 0; i < commandArguments.Length; i++)
            {
                arguments = commandArguments[i];
                commandArguments[i] = arguments.Trim();
            }

            var command = new Command { CommandName = nameCommand, Parameters = commandArguments };

            return command;
        }
    }
}
