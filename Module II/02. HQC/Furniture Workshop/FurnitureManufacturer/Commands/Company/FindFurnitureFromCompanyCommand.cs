using FurnitureManufacturer.Commands.Contracts;
using FurnitureManufacturer.Engine;
using FurnitureManufacturer.Engine.Contracts;
using FurnitureManufacturer.Models.Contracts;
using System.Collections.Generic;

namespace FurnitureManufacturer.Commands.Company
{
    public class FindFurnitureFromCompanyCommand : ICommand
    {
        // Fields
        private readonly IDataStore data;
        private readonly Constants constants;

        // Constructor
        public FindFurnitureFromCompanyCommand(IDataStore data, Constants constants)
        {
            this.data = data;
            this.constants = constants;
        }

        // Method coming from ICommand
        public string Execute(IList<string> parameters)
        {
            string companyName = parameters[0];
            string furnitureModel = parameters[1];

            if (!this.data.Companies.ContainsKey(companyName))
            {
                return string.Format(this.constants.CompanyNotFoundErrorMessage, companyName);
            }

            ICompany company = this.data.Companies[companyName];
            IFurniture furniture = company.Find(furnitureModel);

            if (furniture == null)
            {
                return string.Format(this.constants.FurnitureNotFoundErrorMessage, furnitureModel);
            }

            return furniture.ToString();
        }
    }
}