using System;
using System.Text.RegularExpressions;

namespace _18_ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split();
            Regex regex = new Regex("(.?)*@[a-zA-Z]{1,}\\.[a-zA-Z]{1,}\\.*[a-zA-Z]*");

            for(int i = 0; i < text.Length; i++)
            {
                if (regex.IsMatch(text[i]))
                {
                    Console.WriteLine(text[i]);
                }
            }
        }
    }
}
