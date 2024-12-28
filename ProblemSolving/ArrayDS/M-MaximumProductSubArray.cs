namespace ProblemSolving.ArrayDS;

internal class M_MaximumProductSubArray
{

    // https://leetcode.com/problems/maximum-product-subarray/

    // Time complexity: O(n)
    public static int MaxProductSubArray()
    {
        int[] nums = [2, 3, -2, 4];

        if (nums.Length == 0) return 0;

        // Initialize variables
        int maxProd = nums[0];
        int minProd = nums[0];
        int result = nums[0];

        // Traverse the array
        for (int i = 1; i < nums.Length; i++)
        {
            // If the current number is negative, swap maxProd and minProd
            if (nums[i] < 0)
            {
                int temp = maxProd;
                maxProd = minProd;
                minProd = temp;
            }

            // Update maxProd and minProd
            maxProd = Math.Max(nums[i], maxProd * nums[i]);
            minProd = Math.Min(nums[i], minProd * nums[i]);

            // Update the result with the largest product so far
            result = Math.Max(result, maxProd);
        }

        return result;
    }
}
