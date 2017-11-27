using System;

namespace _07_EncodeDecode
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine();
            var text = Console.ReadLine();
            var index = 0;
            var result = "";

            for(int i = 0; i < text.Length; i++)
            {
                result += text[i] ^ key[index];
                index++;
                if(index == key.Length - 1)
                {
                    index = 0;
                }
            }
            Console.WriteLine(result);
        }
    }
}
