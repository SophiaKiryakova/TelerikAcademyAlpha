using System;
using System.Linq;

namespace _03_SignalFromSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = Console.ReadLine().ToList();
            int i = 0;

            for (; i < message.Count - 1; i++)
            {
                if (message[i] == message[i + 1])
                {
                    message.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine(string.Join("", message));
        }
    }
}
