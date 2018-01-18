using Bytes2you.Validation;
using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Common.Enums;

namespace Dealership.Models
{
    public class Truck : Vehicle, ITruck
    {
        private int weightCapacity;
        public Truck(string make, string model, decimal price, int weightCapacity) : base(make, model, price)
        {
            this.WeightCapacity = weightCapacity;
            this.Wheels = (int)VehicleType.Truck;
        }

        public int WeightCapacity
        {
            get
            {
                return this.weightCapacity;
            }
            set
            {
                if(value < 1 || value > 100)
                {
                    throw new ArgumentException("Weight capacity must be between 1 and 100!");
                }
                this.weightCapacity = value;
            }
        }
        public override VehicleType Type => VehicleType.Truck;

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append($"{Type}:\n{base.ToString()}\n  Weight capacity: {WeightCapacity}t");

            return sb.ToString().TrimEnd();
        }
    }
}
