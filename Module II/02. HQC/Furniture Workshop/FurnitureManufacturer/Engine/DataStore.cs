using FurnitureManufacturer.Engine.Contracts;
using FurnitureManufacturer.Models.Contracts;
using System;
using System.Collections.Generic;

namespace FurnitureManufacturer.Engine
{
    public class DataStore : IDataStore
    {
        // Fields
        private readonly IDictionary<string, ICompany> companies;
        private readonly IDictionary<string, IFurniture> furniture;

        // Constructor
        public DataStore()
        {
            this.companies = new Dictionary<string, ICompany>();
            this.furniture = new Dictionary<string, IFurniture>();
        }

        // Properties
        public IDictionary<string, ICompany> Companies
        {
            get
            {
                return new Dictionary<string, ICompany>(this.companies);
            }
        }
        public IDictionary<string, IFurniture> Furniture
        {
            get
            {
                return new Dictionary<string, IFurniture>(this.furniture);
            }
        }

        // Methods
        public void AddCompany(ICompany company)
        {
            if (string.IsNullOrEmpty(company.Name) || string.IsNullOrWhiteSpace(company.Name))
            {
                throw new ArgumentNullException("Company name cannot be null or empty!");
            }
            this.companies.Add(company.Name, company);
        }

        public void AddFurniture(IFurniture furniture)
        {
            if (string.IsNullOrEmpty(furniture.Model) || string.IsNullOrWhiteSpace(furniture.Model))
            {
                throw new ArgumentNullException("Furniture model cannot be null or empty!");
            }
            this.furniture.Add(furniture.Model, furniture);
        }
    }
}
