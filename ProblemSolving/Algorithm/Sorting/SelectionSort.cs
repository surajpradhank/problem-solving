using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Algorithm.Sorting;

internal class SelectionSort
{
    // Selection sort - we find the smallest element and swap it with the first element

    public static int[] SelectionSortMain()
    {
        int[] num = [7, 8, 3, 1, 2];
        int n = num.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int smallest = i;

            for (int j = i + 1; j < n; j++)
            {
                if (num[smallest] > num[j]) 
                {
                    smallest = j;
                }
            }
            int temp = num[smallest];
            num[smallest] = num[i];
            num[i] = temp;
        }

        return num;
    }
}
