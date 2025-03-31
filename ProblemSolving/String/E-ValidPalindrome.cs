using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.String
{
    internal class E_ValidPalindrome
    {
        public void ValidPalindrome()
        {
            string input = "A man, a plan, a canal: Panama";

            string cleanedString = new string(input.ToLower().Where(char.IsLetterOrDigit).ToArray());
            int n = cleanedString.Length;
            for (int i = 0; i < n / 2; i++)
            {
                if (cleanedString[i] != cleanedString[n - i - 1])
                    Console.WriteLine("Not a valid palindrome");
            }
            Console.WriteLine("Valid Palindrome");
        }
    }
}
