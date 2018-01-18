using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _11_FormatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            string hexValue = number.ToString("X");
            var numberPercentage = number / 100.0;
            Console.WriteLine("{0, 15}",hexValue); // Hexadecimal Value
            Console.WriteLine("{0, 15}", numberPercentage.ToString("P", CultureInfo.InvariantCulture)); // Percentage
            Console.WriteLine("{0, 15}", number.ToString("G2", CultureInfo.InvariantCulture)); // Scientific notation
        }
    }
}
