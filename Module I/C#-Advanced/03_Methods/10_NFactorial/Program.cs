using System;
using System.Numerics;

namespace _10_NFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();
            var factorial = CalculateNFactorial(number);

            Console.WriteLine(factorial);
        }

        private static BigInteger CalculateNFactorial(string number)
        {
            var num = BigInteger.Parse(number);
            BigInteger factorial = 1;

            for(int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
