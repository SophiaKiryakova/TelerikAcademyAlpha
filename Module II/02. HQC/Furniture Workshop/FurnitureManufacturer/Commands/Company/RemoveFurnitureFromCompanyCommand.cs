using FurnitureManufacturer.Commands.Contracts;
using FurnitureManufacturer.Engine;
using FurnitureManufacturer.Engine.Contracts;
using FurnitureManufacturer.Models.Contracts;
using System.Collections.Generic;

namespace FurnitureManufacturer.Commands.Company
{
    public class RemoveFurnitureFromCompanyCommand : ICommand
    {
        // Fields
        private readonly IDataStore data;
        private readonly Constants constants;

        // Constructor
        public RemoveFurnitureFromCompanyCommand(IDataStore data, Constants constants)
        {
            this.data = data;
            this.constants = constants;
        }

        // Method coming from ICommand
        public string Execute(IList<string> parameters)
        {
            string companyName = parameters[0];
            string furnitureName = parameters[1];

            if (!this.data.Companies.ContainsKey(companyName))
            {
                return string.Format(constants.CompanyNotFoundErrorMessage, companyName);
            }

            if (!this.data.Furniture.ContainsKey(furnitureName))
            {
                return string.Format(constants.FurnitureNotFoundErrorMessage, furnitureName);
            }

            ICompany company = this.data.Companies[companyName];
            IFurniture furniture = this.data.Furniture[furnitureName];
            company.Remove(furniture);

            return string.Format(constants.FurnitureRemovedSuccessMessage, furnitureName, companyName);
        }
    }
}