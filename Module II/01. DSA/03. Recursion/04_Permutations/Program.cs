using System;
using System.Collections.Generic;

namespace _04_Permutations
{
    class Program
    {
        static List<string> list;
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            var n = int.Parse(Console.ReadLine());
            var arr = new int[n];
            list = new List<string>();

            // Fill the array with numbers from 1 to N
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }
            FindPermutations(arr, 0);
            Console.WriteLine(string.Join(", ", list));
        }

        private static void FindPermutations(int[] arr, int index)
        {
            if (index == arr.Length)
            {
                var str = "{";

                for(int i = 0; i < arr.Length; i++)
                {
                    if(i < arr.Length - 1)
                    {
                        str += arr[i] + ", ";
                    }
                    else
                    {
                        str += arr[i] + "}";
                    }
                }
                list.Add(str);
            }
            else
            {
                for (int i = index; i < arr.Length; i++)
                {
                    int temp = arr[i];
                    arr[i] = arr[index];
                    arr[index] = temp;
                    FindPermutations(arr, index + 1);
                    temp = arr[i];
                    arr[i] = arr[index];
                    arr[index] = temp;
                }
            }
        }
    }
}
