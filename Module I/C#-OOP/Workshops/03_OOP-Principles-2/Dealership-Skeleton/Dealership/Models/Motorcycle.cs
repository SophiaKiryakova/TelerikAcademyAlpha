using Bytes2you.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Common.Enums;
using Dealership.Contracts;

namespace Dealership.Models
{
    public class Motorcycle: Vehicle, IMotorcycle
    {
        private string category;
        public Motorcycle(string make, string model, decimal price, string category) : base(make, model, price)
        {
            this.Category = category;
            this.Wheels = (int)VehicleType.Motorcycle;
        }
        public string Category
        {
            get
            {
                return this.category;
            }
            set
            {
                if (value.Length < 3 || value.Length > 10)
                {
                    throw new ArgumentException("Category must be between 3 and 10 characters long!");
                }
                else if(value == null)
                {
                    throw new ArgumentNullException("Category cannot be null or empty!");
                }
                this.category = value;
            }
        }

        public override VehicleType Type => VehicleType.Motorcycle;

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{Type}:\n{base.ToString()}\n  Category: {Category}");

            return sb.ToString().TrimEnd();
        }
    }
}
