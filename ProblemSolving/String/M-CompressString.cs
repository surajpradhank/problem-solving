using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.String
{
    internal class M_CompressString
    {

        

        /// <summary>
        /// Compress String - 
        /// The compressed string should not be returned separately but it be stored inside the input character array
        /// input - [aaabbc]
        /// output = 6 as a3b2c1 total string length = 6
        /// </summary>
        public void CompressString()
        {
            char[] input = ['a', 'a', 'a', 'b', 'b', 'c'];


            int index = 0;
            int i = 0;
            while (i < input.Length)
            {
                char currentChar = input[i];
                int count = 0;

                while (i < input.Length && input[i] == currentChar)
                {
                    count++;
                    i++;
                }
                input[index] = currentChar;
                index++;
                input[index] = Convert.ToChar(count);
                index++;
                //
                //if count is 10 then it will be stored as '1','0'
                //foreach (char c in count.ToString())
                //{
                //    input[index] = c;
                //    index++;
                //}

            }
            Console.WriteLine($"Length - {index}");

        }
    }
}
