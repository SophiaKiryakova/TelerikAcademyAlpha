using FurnitureManufacturer.Commands.Contracts;
using FurnitureManufacturer.Engine;
using FurnitureManufacturer.Engine.Contracts;
using FurnitureManufacturer.Models.Contracts;
using System.Collections.Generic;

namespace FurnitureManufacturer.Commands.Create
{
    public class CreateTableCommand : ICommand
    {
        // Fields
        private IDataStore data;
        private Constants constants;
        private IFurnitureFactory furnitureFactory;

        // Constructor
        public CreateTableCommand(IDataStore data, Constants constants, IFurnitureFactory furnitureFactory)
        {
            this.data = data;
            this.constants = constants;
            this.furnitureFactory = furnitureFactory;
        }

        // Method coming from ICommand
        public string Execute(IList<string> parameters)
        {
            string model = parameters[0];
            string material = parameters[1];
            decimal price = decimal.Parse(parameters[2]);
            decimal height = decimal.Parse(parameters[3]);
            decimal length = decimal.Parse(parameters[4]);
            decimal width = decimal.Parse(parameters[5]);

            if (this.data.Furniture.ContainsKey(model))
            {
                return string.Format(constants.FurnitureExistsErrorMessage, model);
            }

            IFurniture table = this.furnitureFactory.CreateTable(model, material, price, height, length, width);
            this.data.AddFurniture(table);

            return string.Format(constants.TableCreatedSuccessMessage, model);
        }
    }
}