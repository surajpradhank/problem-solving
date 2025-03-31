using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.String
{
    internal class M_ReverseWordsInString
    {
        public void ReverseWordsInString()
        {
            string input = "I am suraj kumar pradhan";
            
            char[] charArr = input.ToCharArray();
            int start = 0;

            for (int i = 0; i <= charArr.Length; i++)
            {
                // If we hit a space or end of the string, reverse the word
                if (i == charArr.Length || charArr[i] == ' ')
                {
                    ReverseChars(charArr, start, i - 1);
                    start = i + 1; // Move to the next word
                }
            }

            Console.WriteLine("Output " + new string(charArr));
        }

        public void ReverseChars(char[] charArr, int left, int right)
        {
            while (left < right)
            {
                // Swap characters
                char temp = charArr[left];
                charArr[left] = charArr[right];
                charArr[right] = temp;
                left++;
                right--;
            }
        }


        public static string ReverseWords(string input)
        {
            string result = "";
            string word = "";

            foreach (char c in input)
            {
                if (c == ' ')
                {
                    result += word + " ";
                    word = "";
                }
                else
                {
                    word = c + word; // Reverse the word character by character
                }
            }

            result += word; // Add the last word
            return result;
        }
    }
}
