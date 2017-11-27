using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_AppearanceCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeArr = int.Parse(Console.ReadLine());
            var arr = Console.ReadLine().Split().Select(int.Parse).ToList();
            var number = int.Parse(Console.ReadLine());
            int count = FindCountOfNumber(arr, number);

            Console.WriteLine(count);
        }

        private static int FindCountOfNumber(List<int> arr, int number)
        {
            int count = arr.Count(x => x == number);
            return count;
        }
    }
}
