using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Common;
using Bytes2you.Validation;

namespace Cosmetics.Products
{
    public class Cream : Product, ICream
    {
        private readonly ScentType scent;
        private string name;
        private string brand;

        // Constructor
        public Cream(string name, string brand, decimal price, GenderType gender, ScentType scent)
            : base(name, brand, price, gender)
        {
            Guard.WhenArgument(name.Length, "Name length must be bigger than three").IsLessThan(3).IsGreaterThan(15).Throw();
            Guard.WhenArgument(brand.Length, "Brand length must be bigger than three").IsLessThan(3).IsGreaterThan(15).Throw();
            this.Name = name;
            this.Brand = brand;
            this.scent = scent;
        }
        // Property
        public ScentType Scent => this.scent;
        public override string Name { get; }
        public override string Brand { get; }
        public override string Print()
        {
            var sb = new StringBuilder();
            sb.Append(base.Print());
            sb.Append($"  #Scent: {this.Scent}");
            return sb.ToString();
        }
    }
}
