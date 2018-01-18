using System;

namespace _01_BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 1, 5, 15, 30, 47, 56, 89, 101 };
            var value = 56;
          
            Console.WriteLine(BinarySearch(value, array, 0, array.Length - 1));
        }
        private static int BinarySearch(int value, int[] array, int leftIndex, int rightIndex)
        {
            var middleIndex = (leftIndex + rightIndex) / 2;
            var middleElement = array[middleIndex];

            if (rightIndex < leftIndex)
            {
                return -1;
            }
            if (middleElement == value)
            {
                return middleIndex;
            }
            if(middleIndex < value)
            {
                leftIndex = middleIndex + 1;
            }
            else
            {
                rightIndex = middleIndex - 1;
            }

            var result = BinarySearch(value, array, leftIndex, rightIndex);
            return result;
        }
    }
}
