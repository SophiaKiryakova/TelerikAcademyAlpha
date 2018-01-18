using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayOfIntegers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            // Problem 6. Divisible by 7 and 3
            //    Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
            //    Use the built-in extension methods and lambda expressions.Rewrite the same with LINQ.

            int[] numbers = { 10, 45, 15, 39, 21, 26 };

            var divisibleNums =
            from num in numbers
            where num % 3 == 0
            where num % 7 == 0
            select num;

            PrintNumbers(divisibleNums);

            // With LINQ
            var divisibleNumsLinq = numbers.Where(x => x % 3 == 0 && x % 7 == 0);
            PrintNumbers(divisibleNumsLinq);
        }
        private static void PrintNumbers(IEnumerable<int> collectionNums)
        {
            foreach (var num in collectionNums)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
