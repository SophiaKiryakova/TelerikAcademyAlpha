using System;

namespace Practice_05_FindCountOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Write a program in C# Sharp to count the number of digits in a number using recursion.

            Console.WriteLine("Enter a number N:");
            var n = Console.ReadLine();
            int count = 0;

            FindNumberOfDigits(n, count);
        }

        private static void FindNumberOfDigits(string n, int count)
        {
            if(n.Length == 0)
            {
                Console.WriteLine(count);
                return;
            }
            else
            {
                count++;
                FindNumberOfDigits(n.Substring(0, n.Length - 1), count);
            }
        }
    }
}
