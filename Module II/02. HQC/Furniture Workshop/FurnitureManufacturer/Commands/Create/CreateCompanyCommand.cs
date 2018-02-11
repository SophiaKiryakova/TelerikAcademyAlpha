using FurnitureManufacturer.Commands.Contracts;
using FurnitureManufacturer.Engine;
using FurnitureManufacturer.Engine.Contracts;
using FurnitureManufacturer.Models.Contracts;
using System.Collections.Generic;

namespace FurnitureManufacturer.Commands.Create
{
    public class CreateCompanyCommand : ICommand
    {
        // Fields
        private IDataStore data;
        private Constants constants;
        private ICompanyFactory companyFactory;

        // Constructor
        public CreateCompanyCommand(IDataStore data, Constants constants, ICompanyFactory companyFactory)
        {
            this.data = data;
            this.constants = constants;
            this.companyFactory = companyFactory;
        }

        // Method coming from ICommand
        public string Execute(IList<string> parameters)
        {
            string name = parameters[0];
            string registrationNumber = parameters[1];

            if (this.data.Companies.ContainsKey(name))
            {
                return string.Format(constants.CompanyExistsErrorMessage, name);
            }

            ICompany company = this.companyFactory.CreateCompany(name, registrationNumber);
            this.data.AddCompany(company);

            return string.Format(constants.CompanyCreatedSuccessMessage, name);
        }
    }
}