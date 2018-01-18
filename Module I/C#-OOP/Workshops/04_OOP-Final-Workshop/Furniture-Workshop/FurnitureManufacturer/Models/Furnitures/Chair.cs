using FurnitureManufacturer.Interfaces;
using System.Text;

namespace FurnitureManufacturer.Models.Furnitures
{
    public class Chair : Furniture, IFurniture, IChair
    {
        private int numberOfLegs;
        public Chair(string model, string material, decimal price, decimal height, int numberOfLegs) : base(model, material, price, height)
        {
            this.NumberOfLegs = numberOfLegs;
        }
        public int NumberOfLegs
        {
            get
            {
                return this.numberOfLegs;
            }
            private set
            {
                this.numberOfLegs = value;
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append($", Legs: {this.NumberOfLegs}");
            return sb.ToString();
        }
    }
}
