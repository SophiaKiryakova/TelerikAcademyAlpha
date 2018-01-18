using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_GeneratingAndPrintingSubsetsFromSet
{
    class Program
    {
        static List<string> list;
        static string[] set;
        static void Main(string[] args)
        {
            Console.Write("Enter a set, separated by a comma ',': ");
            set = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Console.Write("Enter K: ");
            var k = int.Parse(Console.ReadLine());
            var arr = new int[k];
            list = new List<string>();

            FindVariations(arr, 0, 0);
            Console.WriteLine(string.Join(", ", list));
        }

        private static void FindVariations(int[] arr, int index, int start)
        {
            if (index >= arr.Length)
            {
                var str = "(";
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i < arr.Length - 1)
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
                for(int i = start; i < set.Length; i++)
                {
                    arr[index] = i;
                    FindVariations(arr, index + 1, i + 1);
                }
            }
        }
    }
}
