using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_LargerThanNeighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeArr = int.Parse(Console.ReadLine());
            var arr = Console.ReadLine().Split().Select(int.Parse).ToList();
            int count = FindCountLargerThanNeighboursNums(arr);
            Console.WriteLine(count);
        }

        private static int FindCountLargerThanNeighboursNums(List<int> arr)
        {
            int count = 0;

            for(int i = 1; i < arr.Count - 1; i++)
            {
                var element = arr[i];

                if(element > arr[i - 1] && element > arr[i + 1])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
