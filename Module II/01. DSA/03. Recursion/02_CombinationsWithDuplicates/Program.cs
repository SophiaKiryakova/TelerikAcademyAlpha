using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CombinationsWithDuplicates
{
    class Program
    {
        static List<string> list;
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());
            list = new List<string>();
            int[] arr = new int[k];
            GetCombinations(arr, 0, 1, n);
            Console.WriteLine(string.Join(", ", list));
        }

        private static void GetCombinations(int[] arr, int index, int start, int end)
        {
            if (index >= arr.Length)
            {
                var str = "(";
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i < arr.Length - 1)
                    {
                        str += arr[i] + " ";
                    }
                    else
                    {
                        str += arr[i] + ")";
                    }
                }
                list.Add(str);
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    arr[index] = i;
                    GetCombinations(arr, index + 1, i, end);
                }
            }
        }
    }
}
