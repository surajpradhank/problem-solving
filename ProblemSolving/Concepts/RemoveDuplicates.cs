using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Concepts;

internal class RemoveDuplicates
{
    public static int[] RemoveDuplicatesFromArray(int[] nums)
    {
        Array.Sort(nums);
        if (nums.Length == 0) return nums;
        int j = 0;
        for (int i = 1; i < nums.Length; i++)
        {

            if (nums[i] != nums[i - 1])
                nums[++j] = nums[i];
        }
        int[] result = new int[j+1];
        for (int k = 0; k < j; k++)
        {
            result[k] = nums[k];
        }
        return result;

    }
}
