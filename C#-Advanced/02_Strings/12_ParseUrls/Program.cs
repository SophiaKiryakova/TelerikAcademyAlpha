using System;
using System.Linq;

namespace _12_ParseUrls
{
    class Program
    {
        static void Main(string[] args)
        {
            var link = Console.ReadLine().Split(new string[] { "://" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var protocol = link[0];
            var server = link[1].Substring(0, link[1].IndexOf('/'));
            var resource = link[1].Substring(link[1].IndexOf('/'));
            
            Console.WriteLine("[protocol] = {0}\n[server] = {1}\n[resource] = {2}", protocol, server, resource);
        }
    }
}
