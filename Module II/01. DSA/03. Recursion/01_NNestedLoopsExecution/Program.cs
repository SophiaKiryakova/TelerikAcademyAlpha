using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_NNestedLoopsExecution
{
    class Program
    {
        static List<string> list;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number N:");
            var n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            list = new List<string>();

            GetNestedLoops(arr, 0, 1, n);

            foreach(var num in list)
            {
                Console.WriteLine(num);
            }
        }

        private static void GetNestedLoops(int[] arr, int index, int start, int end)
        {
            if (index >= arr.Length)
            {
                var str = "";

                for (int i = 0; i < arr.Length; i++)
                {
                    if (i < arr.Length - 1)
                    {
                        str += arr[i] + " ";
                    }
                    else
                    {
                        str += arr[i];
                    }
                }
                list.Add(str);
            }
            else
            {
                for(int i = start; i <= end; i++)
                {
                    arr[index] = i;
                    GetNestedLoops(arr, index + 1, i, end);
                }
            }
        }
    }
}
