using Autofac;
using FurnitureManufacturer.Commands.Contracts;
using FurnitureManufacturer.Engine.Contracts;

namespace FurnitureManufacturer.Engine.Factories
{
    public class CommandsFactory : ICommandsFactory
    {
        // Field
        // We use Autofac's IComponentContext
        private readonly IComponentContext container;

        // Constructor
        public CommandsFactory(IComponentContext container)
        {
            this.container = container;
        }

        // Method
        public ICommand GetCommand(string commandName)
        {
            return this.container.ResolveNamed<ICommand>(commandName);
        }
    }
}
