using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.ArrayDS;

// Subsequence is a contiguous/non contiguous sequence of elements in an array or string , which follows the order of the array or string 

internal class H_SubSequence
{

    public static void SubSequenceMain()
    {
        int[] numArray = { 3,1,2 };
        int n = numArray.Length;
        // Subsequence of the array num is {3,1,2} , {3,1} , {3,2} , {1,2} , {3} , {1} , {2} , {}

        List<int> output = new List<int>();

        Console.WriteLine("Subsequence of the array is : ");
        PrintSubSequence(0, output, numArray, n);
    }

    private static void PrintSubSequence(int index, List<int> output, int[] numArray, int n)
    {
        if (index == n)
        {
            Console.WriteLine(string.Join(",", output));
            return;
        }

        // take condition, to include the element in the subsequence
        output.Add(numArray[index]);
        PrintSubSequence(index + 1, output, numArray, n);
        output.Remove(numArray[index]);

        // not take condition, to not include the element in the subsequence
        PrintSubSequence(index + 1, output, numArray, n);
    }
}
