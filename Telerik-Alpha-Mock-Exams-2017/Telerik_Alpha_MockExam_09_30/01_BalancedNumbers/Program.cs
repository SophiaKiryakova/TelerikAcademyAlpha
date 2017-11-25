using System;

namespace _01_BalancedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumBalanced = 0;

            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                int number = n;
                int thirdDigit = n % 10;
                n /= 10;
                int secondDigit = n % 10;
                int firstDigit = n / 10;
                int sum = firstDigit + thirdDigit;

                if (sum != secondDigit)
                {
                    break;
                }
                sumBalanced += number;
            }
            Console.WriteLine(sumBalanced);
        }
    }
}
