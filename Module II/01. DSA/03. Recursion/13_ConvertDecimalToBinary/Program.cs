using System;
using System.Collections.Generic;

namespace _13_ConvertDecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            // 13. Write a program in C# Sharp to convert a decimal number to binary using recursion.

            Console.WriteLine("Input decimal number: ");
            var number = int.Parse(Console.ReadLine());
            var list = new List<int>();

            ConvertDecimalToBinary(number, list);
        }
        private static void ConvertDecimalToBinary(int number, List<int> list)
        {
            if(number < 1)
            {
                list.Reverse();
                Console.WriteLine($"Number in binary: {string.Join("", list)}");
                return;
            }
            list.Add(number % 2);
            number /= 2;
            ConvertDecimalToBinary(number, list);
        }
    }
}
