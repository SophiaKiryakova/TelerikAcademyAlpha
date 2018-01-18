using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ReverseSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var ending = text[text.Length - 1];
            var newText = text.Split(new char[] { ' ', '.', '!' }, StringSplitOptions.None).ToArray();
            var sb = new StringBuilder();
            
            for(int i = newText.Length -1; i >= 0; i--)
            {
                if(i == newText.Length - 1)
                {
                    sb.Append(newText[i].Trim() + " ");
                }
                else if(i < newText.Length - 1 && i > 0)
                {
                    sb.Append(newText[i] + " ");
                }
                else
                {
                    sb.Append(newText[i]);
                }
            }
            sb.Append(ending);
            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
