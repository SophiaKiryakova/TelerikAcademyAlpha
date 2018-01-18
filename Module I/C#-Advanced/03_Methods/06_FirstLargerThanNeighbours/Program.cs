using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_FirstLargerThanNeighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeArr = int.Parse(Console.ReadLine());
            var arr = Console.ReadLine().Split().Select(int.Parse).ToList();
            int index = FindFirstLargerThanNeighboursNum(arr);

            Console.WriteLine(index);
        }

        private static int FindFirstLargerThanNeighboursNum(List<int> arr)
        {
            for (int i = 1; i < arr.Count - 1; i++)
            {
                var element = arr[i];

                if (element > arr[i - 1] && element > arr[i + 1])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
