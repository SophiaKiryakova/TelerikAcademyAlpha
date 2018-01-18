using Bytes2you.Validation;
using FurnitureManufacturer.Interfaces;
using System.Text;

namespace FurnitureManufacturer.Models.Furnitures
{
    public class Table : Furniture, ITable
    {
        private decimal length;
        private decimal width;
        public Table(string model, string material, decimal price, decimal height, decimal length, decimal width) : base(model, material, price, height)
        {
            this.Length = length;
            this.Width = width;
        }
        public decimal Length
        {
            get
            {
                return this.length;
            }
            set
            {
                this.length = value;
            }
        }

        public decimal Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }

        public decimal Area
        {
            get
            {
                return this.Length * this.Width;
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append($", Length: {this.Length}, Width: {this.Width}, Area: {this.Area}");
            return sb.ToString();
        }
    }
}
