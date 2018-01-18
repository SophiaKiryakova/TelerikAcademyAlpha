using System;

namespace Practice_09_FindFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // 9. Write a program in C# Sharp to find the factorial of a given number using recursion

            Console.WriteLine("Enter a number N:");
            var n = int.Parse(Console.ReadLine());

            FindFactorial(n, 1, 1);
        }

        private static void FindFactorial(int n, int start, int multiplier)
        {
            if(multiplier > n)
            {
                Console.WriteLine(start);
                return;
            }
            start *= multiplier;
            multiplier++;
            FindFactorial(n, start, multiplier);
        }
    }
}
