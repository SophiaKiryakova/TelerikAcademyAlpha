using System;
using System.Collections.Generic;
using System.Linq;

namespace _14_IntegerCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            PrintMinimumFromNums(numbers);
            PrintMaximumFromNums(numbers);
            PrintAverageFromNums(numbers);
            PrintSumOfNums(numbers);
            PrintProductOfNums(numbers);
        }

        private static void PrintProductOfNums(List<int> numbers)
        {
            long product = 1;

            for(int i = 0; i < numbers.Count; i++)
            {
                product *= numbers[i];
            }
            Console.WriteLine(product);
        }

        private static void PrintSumOfNums(List<int> numbers)
        {
            Console.WriteLine(numbers.Sum());
        }

        private static void PrintAverageFromNums(List<int> numbers)
        {
            Console.WriteLine("{0:F2}", numbers.Average());
        }

        private static void PrintMaximumFromNums(List<int> numbers)
        {
            Console.WriteLine(numbers.Max());
        }

        private static void PrintMinimumFromNums(List<int> numbers)
        {
            Console.WriteLine(numbers.Min());
        }
    }
}
