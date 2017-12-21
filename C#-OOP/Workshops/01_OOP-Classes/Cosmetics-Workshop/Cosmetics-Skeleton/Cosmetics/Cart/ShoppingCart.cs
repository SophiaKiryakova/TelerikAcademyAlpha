using Bytes2you.Validation;
using Cosmetics.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cosmetics.Cart
{
    public class ShoppingCart
    {
        private readonly ICollection<Product> productList;

        public ShoppingCart()
        {
            this.productList = new List<Product>();
        }

        public ICollection<Product> ProductList
        {
            get { return this.productList; }
        }

        public void AddProduct(Product product)
        {
            Guard.WhenArgument(product, "product").IsNull().Throw();
            this.ProductList.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            Guard.WhenArgument(product, "product").IsNull().Throw();
            // It is better to go through the property ProductList and not through the field
            this.ProductList.Remove(product);
        }

        public bool ContainsProduct(Product product)
        {
            Guard.WhenArgument(product, "product").IsNull().Throw();
            return this.ProductList.Contains(product);
        }

        public decimal TotalPrice()
        {
            decimal price = 0;
            foreach(var product in ProductList)
            {
                price += product.Price;
            }
            return price;
        }
    }
}
