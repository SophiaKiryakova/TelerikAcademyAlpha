using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_02_FromNTo1NaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Write a program in C# to print numbers from n to 1 using recursion. 

            Console.WriteLine("Enter a number N:");
            int n = int.Parse(Console.ReadLine());

            FindNaturalNumbers(n, 1);
        }

        private static void FindNaturalNumbers(int n, int end)
        {
            if(n < end)
            {
                return;
            }
            else
            {
                Console.Write(n + " ");
                FindNaturalNumbers(n - 1, 1);
            }
        }
    }
}
