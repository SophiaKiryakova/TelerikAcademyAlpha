using FurnitureManufacturer.Commands.Contracts;
using FurnitureManufacturer.Engine;
using FurnitureManufacturer.Engine.Contracts;
using FurnitureManufacturer.Models.Contracts;
using System.Collections.Generic;

namespace FurnitureManufacturer.Commands.Create
{
    public class CreateChairCommand : ICommand
    {
        // Fields
        private IDataStore data;
        private Constants constants;
        private IFurnitureFactory furnitureFactory;

        // Constructor
        public CreateChairCommand(IDataStore data, Constants constants, IFurnitureFactory furnitureFactory)
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
            int legs = int.Parse(parameters[4]);

            if (this.data.Furniture.ContainsKey(model))
            {
                return string.Format(constants.FurnitureExistsErrorMessage, model);
            }

            IFurniture chair = this.furnitureFactory.CreateChair(model, material, price, height, legs);
            this.data.AddFurniture(chair);

            return string.Format(constants.ChairCreatedSuccessMessage, model);
        }
    }
}