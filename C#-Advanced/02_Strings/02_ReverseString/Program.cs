using System;

namespace Telerik_02_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var result = "";

            for(int i = text.Length - 1; i >= 0; i--)
            {
                result += text[i];
            }
            Console.WriteLine(result);
        }
    }
}
