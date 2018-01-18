using System;
using System.Linq;

namespace _02_GetLargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var number1 = numbers[0];
            var number2 = numbers[1];
            var number3 = numbers[2];
            var result = 0;
            result = GetMax(number1, number2);
            result = GetMax(result, number3);
            Console.WriteLine(result);
        }

        private static int GetMax(int num1, int num2)
        {
            return Math.Max(num1, num2);
        }
    }
}
