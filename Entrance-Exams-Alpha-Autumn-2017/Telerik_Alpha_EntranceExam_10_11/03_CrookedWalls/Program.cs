using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_CrookedWalls
{
    class Program
    {
        static void Main(string[] args)
        {
            var walls = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var list = new List<long>();

            for(int i = 0; i < walls.Length - 1; i++)
            {
                var difference = Math.Abs(walls[i] - walls[i + 1]);
                list.Add(difference);
            }
            
            int index = 0;
            int step = 0;
            for (; index < list.Count; index+= step)
            {
                var number = list[index];
                if (number % 2 != 0)
                {
                    step = 1;
                }
                else
                {
                    step = 2;
                    if (index + 1 >= 0 && index + 1 < list.Count)
                    {
                        list[index + 1] = 0; 
                    }
                }
            }
            long sum = 0;

            for(int i = 0; i < list.Count; i++)
            {
                if(list[i] % 2 == 0)
                {
                    sum += list[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
