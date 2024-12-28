using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Algorithm.Sorting;

internal class BubbleSort
{

    public static int[] BubbleSortMain()
    {
        int[] arr = [4, 8, 1, 3, 9, 0, 5];
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }

        return arr;

    }
}
