using System;
using System.Collections.Generic;

namespace Practice_06_PrintEvenOddNumbersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6. Write a program in C# to print even or odd numbers in a given range using recursion.

            Console.WriteLine("Enter a number N:");
            var n = int.Parse(Console.ReadLine());
            var oddNumbers = new List<int>();
            var evenNumbers = new List<int>();

            FindEvenAndOddNumbersInRange(n, oddNumbers, evenNumbers, 1);
        }

        private static void FindEvenAndOddNumbersInRange(int n, List<int> oddNumbers, List<int> evenNumbers, int start)
        {
            if(start > n)
            {
                Console.WriteLine($"Odd numbers: {string.Join(", ", oddNumbers)}");
                Console.WriteLine($"Even numbers: {string.Join(", ", evenNumbers)}");
                return;
            }
            else
            {
                if(start % 2 != 0)
                {
                    oddNumbers.Add(start);
                }
                else
                {
                    evenNumbers.Add(start);
                }
                start++;
                FindEvenAndOddNumbersInRange(n, oddNumbers, evenNumbers, start);
            }
        }
    }
}
