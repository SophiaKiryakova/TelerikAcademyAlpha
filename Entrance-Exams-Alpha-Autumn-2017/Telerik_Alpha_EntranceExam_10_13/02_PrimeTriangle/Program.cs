using System;
using System.Collections.Generic;

namespace _02_PrimeTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var primes = new List<bool>();
            primes = GetAllPrimesFromOneToN(n, primes);

            // We create a new list which will be containing the integer values
            var numbers = new List<int>();
            numbers.Add(1);

            for (int i = 2; i <= n; i++)
            {
                if (primes[i] == true)
                {
                    numbers.Add(i);
                }
            }

            // We use two nested for loops to go through all the values in the integer array and print 1 or 0
            for(int i = 0; i < numbers.Count; i++)
            {
                for(int j = 1; j <= numbers[i]; j++)
                {
                    if (numbers.Contains(j))
                    {
                        Console.Write(1);
                    }
                    else
                    {
                        Console.Write(0);
                    }
                }
                Console.WriteLine();
            }
        }

        private static List<bool> GetAllPrimesFromOneToN(int n, List<bool> primes)
        {
            // We use this method to generate a list of boolean values which show if a number is a prime or not
            // First we set all numberse to true
            for(int i = 0; i <= n; i++)
            {
                primes.Add(true);
            }

            // We now change the values of 0 and 1 to false since they are not primes
            primes[0] = primes[1] = false;

            // We loop though the rest of the list and we check if the value. If true, we loop though with another loop in order to
            // change the values to false with a multiplicator
            for(int i = 1; i < primes.Count; i++)
            {
                if(primes[i] == true)
                {
                    for(int multiplicator = 2; multiplicator * i <= n; multiplicator++)
                    {
                        primes[i * multiplicator] = false;
                    }
                }
            }
            return primes;
        }
    }
}
