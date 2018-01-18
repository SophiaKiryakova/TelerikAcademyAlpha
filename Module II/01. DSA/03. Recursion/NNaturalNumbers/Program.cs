using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number N:");
            int n = int.Parse(Console.ReadLine());

            FindNaturalNumbers(n, 1);
        }

        private static void FindNaturalNumbers(int n, int currentNumber)
        {
            if(currentNumber > n)
            {
                return;
            }
            else
            {
                Console.WriteLine(currentNumber);
                currentNumber++;
                FindNaturalNumbers(n, currentNumber);
            }
        }
    }
}
