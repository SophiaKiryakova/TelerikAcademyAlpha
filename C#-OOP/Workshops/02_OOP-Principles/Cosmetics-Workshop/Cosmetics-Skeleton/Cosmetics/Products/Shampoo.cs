using Cosmetics.Common;
using Cosmetics.Contracts;
using System.Text;

namespace Cosmetics.Products
{
    public class Shampoo : Product, IShampoo
    {
        private readonly uint milliliters;
        private readonly UsageType usage;
        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name, brand, price, gender)
        {           
            this.milliliters = milliliters;
            this.usage = usage;
        }

        // Properties
        public uint Milliliters
        {
            get { return this.milliliters; }
        }
        public UsageType Usage
        {
            get { return this.usage; }
        }
        public override string Print()
        {
            var sb = new StringBuilder();
            sb.Append(base.Print());
            sb.Append($"  #Milliliters: {this.Milliliters}\n  #Usage: {this.Usage}");
            return sb.ToString();
        }       
    }
}
