using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_PositiveIntegerSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var positiveIntegers = new List<int>();
            var sum = 0;
            var average = 0.0;

            while(true)
            {
                var input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                positiveIntegers.Add(int.Parse(input));
            }

            // With LINQ
            sum = positiveIntegers.Sum();
            average = positiveIntegers.Average();

            Console.WriteLine($"Sum: {sum}\nAverage: {average}");

            // Without LINQ
            sum = 0;
            for(int i = 0; i < positiveIntegers.Count; i++)
            {
                sum += positiveIntegers[i];
            }
            average = (double)sum / positiveIntegers.Count;
            Console.WriteLine($"Sum: {sum}\nAverage: {average}");
        }
    }
}
