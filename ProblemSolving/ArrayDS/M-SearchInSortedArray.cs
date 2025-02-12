using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.ArrayDS;

internal class M_SearchInSortedArray
{
    /// Thought Process 
    /// If Array is sorted, then
    /// First out first part is sorted, 1st or 2nd  part and to check which part we can do - Arr[start] < Arr[mid] then left is sorted else right is sorted
    /// Then based on that we can apply binary search on that part of array
    /// If we are not able to find in that part then we can move to other part of array
    /// 
    public static void SearchInSortedArrayCall()
    {
        int[] arr = [6, 7, 0, 1, 2, 3, 4, 5];

        var index = SearchInSortedArray(arr, 0);

        Console.WriteLine("Number is present at {0} index", index);
    }

    public static int SearchInSortedArray(int[] num, int target)
    {

        int start = 0;
        int end = num.Length - 1;

        while (start <= end)
        {
            int mid = start + (end - start) / 2;

            if (num[mid] == target)
                return mid;

            if (num[start] < num[mid])
            {
                // left sorted
                if (num[start] <= target && target <= num[mid])
                    end = mid - 1;
                else
                    start = mid + 1;

            }
            else
            {
                //right sorted
                if (num[mid] <= target && target <= num[end])
                    start = mid + 1;
                else
                    end = mid - 1;

            }
        }

        return -1;
    }
}
