using System;
using System.Collections.Generic;

namespace SortIntegersInAscendingOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            var integers = new List<int>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                integers.Add(int.Parse(input));
            }

            // With LINQ
            //integers.Sort();
            Console.WriteLine(string.Join(" ", integers));

            // Without LINQ
            for(int i = 0; i < integers.Count - 1; i++)
            {
                if(integers[i] > integers[i + 1])
                {
                    Swap(integers, i);
                    i = 0;
                }
            }
            Console.WriteLine(string.Join(" ", integers));
        }

        private static void Swap(List<int> integers, int i)
        {
            int temp = integers[i];
            integers[i] = integers[i + 1];
            integers[i + 1] = temp;
        }
    }
}
