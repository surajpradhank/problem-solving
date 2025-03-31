using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.String
{
    internal class E_LongestCommonPrefix
    {

        public void LongestCommonPrefixString()
        {
            string[] input = ["cluster", "clue", "clutch", "club", "clumsy"];

            Array.Sort(input);
            string result = "";
            char[] first = input[0].ToCharArray();
            char[] lastWord = input[input.Length - 1].ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                if (first[i] != lastWord[i])
                    break;
                result += first[i];
            }

            Console.WriteLine("Prefix");
        }

        public string LongestCommonPrefixStringOption2()
        {
            string[] input = ["cluster", "clue", "clutch", "club", "clumsy"];
            string result = "";
            for (int i = 0; i < input[0].Length; i++)
            {

                char curr = input[0][i];

                foreach (string s in input)
                {
                    if (i == s.Length || s[i] != curr)
                        return result;
                }
                result += curr;

            }
            return result;
        }
    }
}
