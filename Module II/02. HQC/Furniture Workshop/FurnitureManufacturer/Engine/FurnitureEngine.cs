using FurnitureManufacturer.Commands.Contracts;
using FurnitureManufacturer.Engine.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FurnitureManufacturer.Engine
{
    public sealed class FurnitureEngine : IEngine
    {
        // Fields
        private readonly IRenderer renderer;
        private readonly ICommandsFactory commandsFactory;

        // Dependency Injection in the constructor
        public FurnitureEngine(IRenderer renderer, ICommandsFactory commandsFactory)
        {
            this.renderer = renderer;
            this.commandsFactory = commandsFactory;
        }

        public void Start()
        {
            List<string> commandResults = new List<string>();

            try
            {
                foreach (string currentLine in this.renderer.Input())
                {
                    commandResults.Add(this.ProcessCommand(currentLine));
                }
            }
            catch (Exception ex)
            {
                commandResults.Add(ex.Message);
            }

            this.renderer.Output(commandResults);
        }

        private string ProcessCommand(string currentLine)
        {
            List<string> commandParts = currentLine.Split(' ').ToList();

            string commandName = commandParts[0];
            List<string> commandParameters = commandParts.Skip(1).ToList();

            ICommand command = this.commandsFactory.GetCommand(commandName.ToLower());
            return command.Execute(commandParameters);
        }
    }
}
