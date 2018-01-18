using System;

namespace Practice_15_PowerOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // 15. Write a program in C# Sharp to calculate the power of any number using recursion.

            Console.WriteLine("Input the base value: ");
            var baseValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the exponent: ");
            var exponent = int.Parse(Console.ReadLine());
            var result = 1L;

            FindThePowerOfNumber(baseValue, exponent, 1, result);
        }

        private static void FindThePowerOfNumber(int baseValue, int exponent, int count, long result)
        {
            if(count > exponent)
            {
                Console.WriteLine($"The result is : {result}");
                return;
            }
            result *= baseValue;
            count++;
            FindThePowerOfNumber(baseValue, exponent, count, result);
        }
    }
}
