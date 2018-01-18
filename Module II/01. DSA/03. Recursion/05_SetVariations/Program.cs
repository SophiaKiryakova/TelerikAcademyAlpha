using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_SetVariations
{
    class Program
    {
        static List<string> list;
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            var n = int.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            var k = int.Parse(Console.ReadLine());
            Console.Write("Enter a set with a size N, separated by a comma ',': ");
            var set = Console.ReadLine().Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var arr = new int[k];
            list = new List<string>();

            FindVariations(set, arr, n, k, 0, 0);
            Console.WriteLine(string.Join(", ", list));
        }

        private static void FindVariations(string[] set, int[] arr, int n, int k, int start, int index)
        {
            if(index >= arr.Length)
            {
                var str = "(";
                for(int i = 0; i < arr.Length; i++)
                {
                    if(i < arr.Length - 1)
                    {
                        str += set[arr[i]] + " ";
                    }
                    else
                    {
                        str += set[arr[i]] + ")";
                    }
                }
                list.Add(str);
            }
            else
            {
                for(int i = start; i < n; i++)
                {
                    arr[index] = i;
                    FindVariations(set, arr, n, k, i + 1, index + 1);
                }
            }
        }
    }
}
