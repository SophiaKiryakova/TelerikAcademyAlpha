using System;

namespace Practice_07_CheckIfNumberIsPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7. Write a program in C# Sharp to check whether a number is prime or not using recursion.
            Console.WriteLine("Enter a number N:");
            var n = int.Parse(Console.ReadLine());

            FindIfNumberIsPrime(n, 2);
        }

        private static void FindIfNumberIsPrime(int n, int diviser)
        {
            if(diviser == n)
            {
                Console.WriteLine($"The number {n} is a prime number.");
                return;
            }
            if(n % diviser == 0)
            {
                Console.WriteLine($"The number {n} is NOT a prime number.");
                return;
            }
            else
            {
                diviser++;
                FindIfNumberIsPrime(n, diviser);
            }
        }
    }
}
