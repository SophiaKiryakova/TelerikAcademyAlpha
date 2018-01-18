using Bytes2you.Validation;
using Cosmetics.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cosmetics
{
    public class Category
    {
        private readonly string name;
        private readonly List<Product> products;

        // Constructors
        public Category(string name)
        {
            Guard.WhenArgument(name.Length, "name").IsLessThan(3).IsGreaterThan(10).Throw();
            this.name = name;
            this.products = new List<Product>();
        }

        public List<Product> Products
        {
            get
            {
                return this.products;
            }
        }

        public virtual void AddProduct(Product product)
        {
            Guard.WhenArgument(product, "product").IsNull().Throw();
            this.Products.Add(product);
        }

        public virtual void RemoveProduct(Product product)
        {
            Guard.WhenArgument(product, "product").IsNull().Throw();
            if (Products.Contains(product))
            {
                this.Products.Remove(product);
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public string Print()
        {
            var strBuilder = new StringBuilder();

            strBuilder.Append($"Category: {this.name}");
            foreach (var product in this.products)
            {
                strBuilder.AppendLine(product.Print());
            }
            return strBuilder.ToString();
        }
    }
}
