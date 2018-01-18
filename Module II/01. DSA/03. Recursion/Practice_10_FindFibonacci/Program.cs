using System;

namespace Practice_10_FindFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10. Write a program in C# to find the Fibonacci numbers for a n numbers of series using recursion.

            Console.WriteLine("Enter a number N:");
            var n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.Write($"{FindFibonacci(i)} ");
            }
        }

        private static int FindFibonacci(int number)
        {
            int first = 0;
            int second = 1;

            for (int i = 0; i < number; i++)
            {
                int temp = first;
                first = second;
                second += temp;
            }
            return first;
        }
    }
}
