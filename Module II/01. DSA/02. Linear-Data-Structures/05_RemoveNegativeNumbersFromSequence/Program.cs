using System;
using System.Collections.Generic;

namespace _05_RemoveNegativeNumbersFromSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, -2, 3, -3, 3, 5, -7, -10, 10, -13 };

            // With LINQ
            //numbers.RemoveAll(x => x < 0);
            Console.WriteLine(string.Join(", ", numbers));

            // Without LINQ - we can put the positive ones in another list
            var positiveNums = new List<int>();

            for(int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] > 0)
                {
                    positiveNums.Add(numbers[i]);
                }
            }
            Console.WriteLine(string.Join(", ", positiveNums));
        }
    }
}
