using Cosmetics.Contracts;
using System.Text;
using Cosmetics.Common;
using Bytes2you.Validation;

namespace Cosmetics.Products
{
    public class Product : IProduct
    {
        private readonly string name;
        private readonly string brand;
        private readonly decimal price;
        private readonly GenderType gender;

        // Constructor
        public Product(string name, string brand, decimal price, GenderType gender)
        {
            Guard.WhenArgument(name, "The name is empty!").IsNullOrEmpty().Throw();
            Guard.WhenArgument(name.Length, "Name length should be equal or more than 3 and less or equal to 10!").IsLessThan(3).IsGreaterThan(10).Throw();
            Guard.WhenArgument(brand, "There should be a brand name!").IsNullOrEmpty().Throw();
            Guard.WhenArgument(brand.Length, "Brand name length should be equal or more than 2 and less or equal to 10!").IsLessThan(2).IsGreaterThan(10).Throw();
            Guard.WhenArgument(price, "Price cannot be negative!").IsLessThan(0).Throw();

            this.name = name;
            this.brand = brand;
            this.price = price;
            this.gender = gender;
        }
        // Properties
        public virtual string Name => this.name;

        public virtual string Brand => this.brand;

        public decimal Price => this.price;

        public GenderType Gender => this.gender;

        public virtual string Print()
        {
            var sb = new StringBuilder();
            sb.Append($"#{this.Name} {this.Brand}\n  #Price: ${this.Price}\n  #Gender: {this.Gender}");
            return sb.ToString().Trim();
        }
    }
}
