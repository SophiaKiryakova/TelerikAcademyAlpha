using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_SortingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeArr = int.Parse(Console.ReadLine());
            var arr = Console.ReadLine().Split().Select(int.Parse).ToList();
            var sortedArr = SortArray(arr, sizeArr);

            Console.WriteLine(string.Join(" ", sortedArr));
        }

        private static List<int> SortArray(List<int> arr, int sizeArr)
        {
            var sortedArr = new List<int>();

            while(sortedArr.Count < sizeArr)
            {
                sortedArr.Add(arr.Min());
                arr.Remove(arr.Min());
            }
            return sortedArr;
        }
    }
}
