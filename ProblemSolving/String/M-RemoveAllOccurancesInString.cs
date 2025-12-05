using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.String
{
    internal class RemoveAllOccurrencesInString
    {
        public void RemoveOccurrences()
        {
            string input = "daabcbaabcbc";
            string part = "abc";
            // dab

            while (input.Contains(part))
            {
                int index = input.IndexOf(part);
                input = input.Remove(index, part.Length);
               // or
               // input = input.Replace(part,"");
            }

            Console.WriteLine(input);
        }
    }
}
