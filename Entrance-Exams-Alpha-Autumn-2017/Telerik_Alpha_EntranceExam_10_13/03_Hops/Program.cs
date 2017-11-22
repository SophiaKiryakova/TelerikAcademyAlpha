using System;
using System.Linq;
using System.Collections.Generic;

namespace _03_Hops
{
    class Program
    {
        static void Main(string[] args)
        {
            var carrots = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int m = int.Parse(Console.ReadLine());
            var maxCarrots = long.MinValue;

            for (int i = 0; i < m; i++)
            {
                var directions = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                if (directions.Length <= 100)
                {
                    long eatenCarrots = CalculateEatenCarrots(carrots, directions);

                    if (eatenCarrots > maxCarrots)
                    {
                        maxCarrots = eatenCarrots;
                    }
                }
            }  
            Console.WriteLine(maxCarrots);
        }

        private static long CalculateEatenCarrots(int[] carrots, int[] directions)
        {
            int index = 0;
            long eatenCarrots = carrots[index];
            var usedIndexes = new HashSet<int>();
            usedIndexes.Add(0);
            int secondIndex = 0;

            while(secondIndex >= 0 && secondIndex < directions.Length)
            {
                if (directions[secondIndex] >= -1000 && directions[secondIndex] <= 1000)
                {
                    index += directions[secondIndex];
                    secondIndex++;
                    if(secondIndex > directions.Length - 1)
                    {
                        secondIndex = 0;
                    }
                    if (index >= 0 && index < carrots.Length && !usedIndexes.Contains(index))
                    {
                        eatenCarrots += carrots[index];
                        usedIndexes.Add(index);
                    }
                    else
                    {
                        break;
                    }
                }
            }
                return eatenCarrots;
        }
    }
}
