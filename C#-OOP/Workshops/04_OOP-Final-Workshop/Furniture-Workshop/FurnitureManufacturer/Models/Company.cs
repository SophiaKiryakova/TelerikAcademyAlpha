using Bytes2you.Validation;
using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FurnitureManufacturer.Models
{
    public class Company : ICompany
    {
        private readonly string name;
        private readonly string registrationNumber;
        private readonly ICollection<IFurniture> furnitures;

        public Company(string name, string registrationNumber)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Company name cannot be null or empty");
            }
            if (!Regex.IsMatch(registrationNumber, "[0-9]{10}"))
            {
                throw new ArgumentException("Registration number is not valid");
            }
            this.name = name;
            this.registrationNumber = registrationNumber;
            this.furnitures = new List<IFurniture>();
        }

        public string Name => this.name;

        public string RegistrationNumber => this.registrationNumber;

        public ICollection<IFurniture> Furnitures => this.furnitures;

        public void Add(IFurniture furniture)
        {
            this.furnitures.Add(furniture);
        }

        public string Catalog()
        {
            var strBuilder = new StringBuilder();

            if(furnitures.Count() < 1)
            {
                strBuilder.AppendLine($"{this.Name} - {this.RegistrationNumber} - no furnitures");
            }
            else if(furnitures.Count() == 1)
            {
                strBuilder.AppendLine($"{this.Name} - {this.RegistrationNumber} - 1 furniture");
            }
            else
            {
                strBuilder.AppendLine($"{this.Name} - {this.RegistrationNumber} - {this.furnitures.Count()} furnitures");
            }
            foreach(var furniture in this.furnitures.OrderBy(x => x.Price).ThenBy(x => x.Model))
            {
                strBuilder.AppendLine(furniture.ToString());
            }
            return strBuilder.ToString().Trim();
        }

        public IFurniture Find(string model)
        {
            if (model == null)
            {
                throw new ArgumentNullException("Model can not be null");
            }
            return this.furnitures.FirstOrDefault(x => x.Model.ToLower() == model.ToLower());

        }

        public void Remove(IFurniture furniture)
        {
            this.furnitures.Remove(furniture);
        }
    }
}
