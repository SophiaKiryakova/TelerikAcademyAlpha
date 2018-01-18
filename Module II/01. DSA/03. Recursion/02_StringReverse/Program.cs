using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputStr = Console.ReadLine();
            inputStr = ReverseStringRecursively(inputStr);
            Console.WriteLine(inputStr);
        }

        private static string ReverseStringRecursively(string inputStr)
        {
            if(inputStr.Length > 0)
            {
                var newStr = inputStr.Substring(0, inputStr.Length - 1);
                var res = inputStr[inputStr.Length - 1] + ReverseStringRecursively(newStr);
                return res;
            }
            else
            {
                return inputStr;
            }
        }
    }
}
