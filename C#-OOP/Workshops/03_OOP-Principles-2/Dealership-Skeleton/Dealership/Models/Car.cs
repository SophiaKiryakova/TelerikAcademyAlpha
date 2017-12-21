using System.Collections.Generic;
using Dealership.Common.Enums;
using Dealership.Contracts;
using Bytes2you.Validation;
using System.Text;
using System;

namespace Dealership.Models
{
    public class Car : Vehicle, ICar
    {
        private int seats;
        public Car(string mark, string model, decimal price, int seats) : base(mark, model, price)
        {
            this.Seats = seats;
            this.Wheels = (int)VehicleType.Car;
        }
        public int Seats
        {
            get
            {
                return this.seats;
            }
            set
            {
                if(value < 1 || value > 10)
                {
                    throw new ArgumentException("Seats must be between 1 and 10!");
                }
                this.seats = value;
            }
        }
        public override VehicleType Type => VehicleType.Car;

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{Type}:\n{base.ToString()}\n  Seats: {Seats}");

            return sb.ToString().TrimEnd();
        }
    }
}
