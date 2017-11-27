using System;

namespace _06_StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var result = text;
            if(text.Length == 20)
            {
                Console.WriteLine(text);
            }
            else
            {
                for(int i = text.Length; i < 20; i++)
                {
                    result += "*";
                }
                Console.WriteLine(result);
            }
        }
    }
}
