using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Algorithm.Sorting
{
    internal class InsertionSort
    {
        // Inserting an element from unsorted array to its correct position in sorted array
        public static int[] InsertionSortMain()
        {

            int[] num = { 7, 8, 3, 1, 2 };
            for (int i = 1; i < num.Length; i++)
            {
                int current = num[i];
                int j = i - 1;
                while (j >= 0 && num[j] > current)
                {
                    num[j + 1] = num[j];
                    j--;
                }
                num[j + 1] = current;
            }
            return num;
        }
    }
}
