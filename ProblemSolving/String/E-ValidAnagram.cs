using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.String
{
    internal class E_ValidAnagram
    {
        public void ValidAnagram(string input1, string input2) 
        {
            Dictionary<char,int> charCheck = new Dictionary<char,int>();
            foreach (char c in input1.ToLower())
            {
                if (charCheck.ContainsKey(c))
                    charCheck[c]++;
                else
                    charCheck[c] = 1;
            }

            foreach (char c in input1.ToLower())
            {
                if (charCheck.ContainsKey(c))
                {
                    charCheck[c]--;
                    if (charCheck[c] == 0)
                        charCheck.Remove(c);
                }
                else
                    Console.WriteLine("Not a valid anagram");
            }

            if (charCheck.Count == 0)
                Console.WriteLine("Valid Anagram");

        }
    }
}
