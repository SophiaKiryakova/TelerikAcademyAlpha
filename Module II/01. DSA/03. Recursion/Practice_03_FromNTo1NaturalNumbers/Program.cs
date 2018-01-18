using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_03_SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Write a program in C# Sharp to find the sum of first n natural numbers using recursion.

            Console.WriteLine("Enter a number N:");
            int n = int.Parse(Console.ReadLine());
            long sum = 0;

            FindSumNaturalNumbers(1, n, sum);
        }

        private static void FindSumNaturalNumbers(int start, int n, long sum)
        {
            if(start > n)
            {
                Console.WriteLine(sum);
                return;
            }
            else
            {
                sum += start;
                FindSumNaturalNumbers(start + 1, n, sum);
            }
        }
    }
}
