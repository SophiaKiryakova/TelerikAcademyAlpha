using System;

namespace _03_EnglishDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var digitAsWord = ReturnLastDigitAsWord(number);
            Console.WriteLine(digitAsWord);
        }

        private static string ReturnLastDigitAsWord(int number)
        {
            var digit = number % 10;
            var digitAsWord = string.Empty;

            switch (digit)
            {
                case 0: digitAsWord = "zero"; break;
                case 1: digitAsWord = "one"; break;
                case 2: digitAsWord = "two"; break;
                case 3: digitAsWord = "three"; break;
                case 4: digitAsWord = "four"; break;
                case 5: digitAsWord = "five"; break;
                case 6: digitAsWord = "six"; break;
                case 7: digitAsWord = "seven"; break;
                case 8: digitAsWord = "eight"; break;
                case 9: digitAsWord = "nine"; break;
            }
            return digitAsWord;
        }
    }
}
