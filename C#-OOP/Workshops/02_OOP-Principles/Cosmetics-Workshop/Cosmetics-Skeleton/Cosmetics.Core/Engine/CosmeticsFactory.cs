﻿using Cosmetics.Cart;
using Cosmetics.Common;
using Cosmetics.Contracts;
using Cosmetics.Products;
using System;
using System.Collections.Generic;

namespace Cosmetics.Core.Engine
{
    public class CosmeticsFactory : ICosmeticsFactory
    {
        public ICategory CreateCategory(string name)
        {
            return new Category(name);
        }

        public IShampoo CreateShampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
        {
            return new Shampoo(name, brand, price, gender, milliliters, usage);
        }
        public IToothpaste CreateToothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
        {
            return new Toothpaste(name, brand, price, gender, string.Join(", ", ingredients));
        }
        public ICream CreateCream(string name, string brand, decimal price, GenderType gender, ScentType scent)
        {
            return new Cream(name, brand, price, gender, scent);
        }
        public IShoppingCart CreateShoppingCart()
        {
            return new ShoppingCart();
        }
    }
}
