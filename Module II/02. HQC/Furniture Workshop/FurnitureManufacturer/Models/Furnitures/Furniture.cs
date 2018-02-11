using FurnitureManufacturer.Models.Contracts;
using System;

namespace FurnitureManufacturer.Models.Furnitures
{
    public abstract class Furniture : IFurniture
    {
        private readonly string model;
        private readonly string material;
        private readonly decimal price;
        private decimal height;

        public Furniture(string model, string material, decimal price, decimal height)
        {
            this.model = model;
            this.material = material;
            this.price = price;
            this.height = height;
        }

        public string Model
        {
            get
            {
                if (string.IsNullOrEmpty(this.model))
                {
                    throw new ArgumentNullException("Furniture model cannot be null or empty!");
                }
                if(this.model.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("Furniture model length cannot be less than 3 symbols!");
                }
                return this.model;
            }
        }

        public string Material
        {
            get
            {
                if (string.IsNullOrEmpty(this.material))
                {
                    throw new ArgumentNullException("Furniture material cannot be null or empty!");
                }
                return this.material;
            }
        }

        public decimal Price
        {
            get
            {
                if (this.price < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be less than zero");
                }
                return this.price;
            }
        }

        public decimal Height
        {
            get
            {
                if(this.height < 0)
                {
                    throw new ArgumentOutOfRangeException("Height cannot be less than zero");
                }
                return this.height;
            }
            protected set
            {
                this.height = value;
            }
        }

        protected abstract string AdditionalInfo();

        public override string ToString()
        {
            return $"Type: {this.GetType().Name}, Model: {this.Model}, Material: {this.Material}, Price: {this.Price}, Height: {this.Height.ToString("0.00")}{this.AdditionalInfo()}";
        }
    }
}
