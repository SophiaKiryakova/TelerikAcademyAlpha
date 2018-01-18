using System;
using System.Text;

namespace _10_UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var result = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                var symbol = text[i];
                int number = symbol;
                string hexDecNum = FindHexDecNumber(number);

                if (hexDecNum.Length == 1)
                {
                    result.Append("\\u000" + hexDecNum);
                }
                else if (hexDecNum.Length == 2)
                {
                    result.Append("\\u00" + hexDecNum);
                }
                else if (hexDecNum.Length == 3)
                {
                    result.Append("\\u0" + hexDecNum);
                }
                else if (hexDecNum.Length == 4)
                {
                    result.Append("\\u" + hexDecNum);
                }
            }
            Console.WriteLine(result.ToString());
        }

        private static string FindHexDecNumber(int number)
        {
            string hexDecNum = "";
            var hexDec = "0123456789ABCDEF";
            int num = 0;

            while(number > 0)
            {
                num = number % 16;
                hexDecNum = hexDec[num] + hexDecNum;
                number /= 16;
            }
            return hexDecNum;
        }
    }
}
