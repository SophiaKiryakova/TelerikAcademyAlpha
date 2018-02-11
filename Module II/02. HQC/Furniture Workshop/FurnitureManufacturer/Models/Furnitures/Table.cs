using FurnitureManufacturer.Models.Contracts;
using System;

namespace FurnitureManufacturer.Models.Furnitures
{
    public class Table : Furniture, ITable
    {
        private readonly decimal length;
        private readonly decimal width;

        public Table(string model, string materialType, decimal price, decimal height, decimal length, decimal width) 
            : base(model, materialType, price, height)
        {
            this.length = length;
            this.width = width;
        }

        public decimal Length
        {
            get
            {
                if(this.length < 0)
                {
                    throw new ArgumentOutOfRangeException("Length cannot be less than zero");
                }
                return this.length;
            }
        }

        public decimal Width
        {
            get
            {
                if (this.width < 0)
                {
                    throw new ArgumentOutOfRangeException("Width cannot be less than zero");
                }
                return this.width;
            }
        }

        public decimal Area => this.width * this.length;

        protected override string AdditionalInfo()
        {
            return $", Length: {this.Length}, Width: {this.Width}, Area: {this.Area}";
        }
    }
}
