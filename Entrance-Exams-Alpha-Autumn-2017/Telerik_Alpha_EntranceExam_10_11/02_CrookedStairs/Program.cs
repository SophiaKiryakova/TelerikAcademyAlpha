using System;
using System.Collections.Generic;

namespace _02_CrookedStairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var brick1 = long.Parse(Console.ReadLine());
            var brick2 = long.Parse(Console.ReadLine());
            var brick3 = long.Parse(Console.ReadLine());
            var layers = long.Parse(Console.ReadLine());
            var list = new List<long>();
            list.Add(brick1); list.Add(brick2); list.Add(brick3);
            int firstIndex = 2;

            // First part: We add all the numbers in the list
            for (int i = 0; i < layers - 2; i++)
            {
                for(int j = 2; j <= layers + 1; j++)
                {
                    var number = list[firstIndex] + list[firstIndex - 1] + list[firstIndex - 2];
                    list.Add(number);
                    firstIndex++;
                }
            }

            // Second part: We print the number pyramid
            int index = 0;
            for (int i = 0; i < layers; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if(j != i)
                    {
                        Console.Write(list[index] + " ");
                    }
                    else
                    {
                        Console.Write(list[index]);
                    }
                    index++;
                }
                Console.WriteLine();
            }
        }
    }
}
