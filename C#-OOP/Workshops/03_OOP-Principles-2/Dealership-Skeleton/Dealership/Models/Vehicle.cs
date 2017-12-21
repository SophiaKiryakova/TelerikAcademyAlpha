using Bytes2you.Validation;
using Dealership.Common.Enums;
using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Models
{
    public abstract class Vehicle: IVehicle
    {
        private string make;
        private string model;
        private decimal price;
        private int wheels;
        private IList<IComment> comments;
        public Vehicle(string make, string model, decimal price)
        {
            this.Make = make;
            this.Model = model;
            this.Price = price;
            this.Comments = new List<IComment>();
        }
        public string Make
        {
            get
            {
                return this.make;
            }
            set
            {

                if(value.Length < 2 || value.Length > 15)
                {
                    throw new ArgumentException("Make must be between 2 and 15 characters long!");
                }
                else if (value == null)
                {
                    throw new ArgumentNullException("Make cannot be null!");
                }
                this.make = value;
            }
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Model must be between 2 and 15 characters long!");
                }
                else if (value == null)
                {
                    throw new ArgumentNullException("Model cannot be null!");
                }
                this.model = value;
            }
        }
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0 || value > 100000)
                {
                    throw new ArgumentException("Price must be between 0.0 and 1000000.0!");
                }
                this.price = value;
            }
        }
        public abstract VehicleType Type { get; }

        public int Wheels { get; set; }

        public IList<IComment> Comments { get; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append($"  Make: {Make}\n  Model: {Model}\n  Wheels: {Wheels}\n  Price: ${Price}");

            return sb.ToString().TrimEnd();
        }
    }
}
