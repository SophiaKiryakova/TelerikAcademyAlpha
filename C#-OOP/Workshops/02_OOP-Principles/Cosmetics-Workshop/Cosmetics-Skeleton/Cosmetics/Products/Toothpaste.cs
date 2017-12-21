using Bytes2you.Validation;
using Cosmetics.Common;
using Cosmetics.Contracts;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Cosmetics.Products
{
    public class Toothpaste : Product, IToothpaste
    {
        private string ingredients;
        public Toothpaste(string name, string brand, decimal price, GenderType gender, string ingredients)
            :base (name, brand, price, gender)
        {
            Guard.WhenArgument(ingredients, "There should be ingredients!").IsNullOrEmpty().Throw();
            this.ingredients = ingredients;
        }
        string IToothpaste.Ingredients
        {
            get { return this.ingredients; }
            set
            {
                Guard.WhenArgument(ingredients, "There should be ingredients!").IsNullOrEmpty().Throw();
                this.ingredients = value;
            }
        }

        public override string Print()
        {
            var sb = new StringBuilder();
            sb.Append(base.Print());
            sb.Append($"\n  #Ingredients: {string.Join(",", this.ingredients)}");
            return sb.ToString();
        }
    }
}