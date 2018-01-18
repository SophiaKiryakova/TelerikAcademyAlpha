using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RemoveOddOccuringNums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

            // We can sort the numbers then check in a loop and put the even occuring ones in a list.
            List<int> evenOccuringNums = new List<int>();
            numbers.Sort();
            int count = 1;
            int number = 0;

            for(int i = 0; i < numbers.Count - 1; i++)
            {
                
            }
            Console.WriteLine(string.Join(", ", evenOccuringNums));
        }
    }
}
