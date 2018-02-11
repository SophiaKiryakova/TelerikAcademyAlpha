using FurnitureManufacturer.Models.Contracts;
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
            this.name = name;
            this.registrationNumber = registrationNumber;
            this.furnitures = new List<IFurniture>();
        }

        public string Name
        {
            get
            {
                if (string.IsNullOrEmpty(this.name))
                {
                    throw new ArgumentNullException("Company name cannot be null nor empty!");
                }
                if(this.name.Length < 5)
                {
                    throw new ArgumentOutOfRangeException("Company name cannot be less than five symbols!");
                }

                return this.name;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                if (string.IsNullOrEmpty(this.registrationNumber))
                {
                    throw new ArgumentNullException("Registration number cannot be null nor empty!");
                }
                if (!Regex.IsMatch(registrationNumber, "[0-9]{10}"))
                {
                    throw new ArgumentException("Registration number is not valid");
                }

                return this.registrationNumber;
            }
        }

        public ICollection<IFurniture> Furnitures => this.furnitures;

        public void Add(IFurniture furniture)
        {
            if(furniture == null)
            {
                throw new ArgumentNullException("Furniture to add cannot be null!");
            }

            this.furnitures.Add(furniture);
        }

        public string Catalog()
        {
            var strBuilder = new StringBuilder();
            var anyFurniture = this.furnitures.Any() ? this.furnitures.Count.ToString() : "no";
            var singleOrPlural = this.furnitures.Count != 1 ? "furnitures" : "furniture";

            strBuilder.AppendLine($"{this.name} - {this.registrationNumber} - {anyFurniture} {singleOrPlural}");
            foreach (var furniture in this.furnitures.OrderBy(x=>x.Price).ThenBy(x=>x.Model))
            {
                strBuilder.AppendLine(furniture.ToString().Trim());
            }

            return strBuilder.ToString().Trim();
        }

        public IFurniture Find(string model)
        {
            if (model == null)
            {
                throw new ArgumentNullException("Model cannot be null!");
            }

            return this.furnitures.FirstOrDefault(x => x.Model.ToLower() == model.ToLower());
        }

        public void Remove(IFurniture furniture)
        {
            if (furniture == null)
            {
                throw new ArgumentNullException("Furniture to remove cannot be null!");
            }

            this.furnitures.Remove(furniture);
        }
    }
}
