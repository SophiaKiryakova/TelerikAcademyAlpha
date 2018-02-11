using FurnitureManufacturer.Commands.Contracts;
using FurnitureManufacturer.Engine;
using FurnitureManufacturer.Engine.Contracts;
using System.Collections.Generic;

namespace FurnitureManufacturer.Commands.Company
{
    public class ShowCompanyCatalogCommand : ICommand
    {
        // Fields 
        private IDataStore data;
        private Constants constants;

        // Constructor
        public ShowCompanyCatalogCommand(IDataStore data, Constants constants)
        {
            this.data = data;
            this.constants = constants;
        }

        // Method coming from ICommand
        public string Execute(IList<string> parameters)
        {
            string companyName = parameters[0];

            if (!this.data.Companies.ContainsKey(companyName))
            {
                return string.Format(constants.CompanyNotFoundErrorMessage, companyName);
            }

            return this.data.Companies[companyName].Catalog();
        }
    }
}