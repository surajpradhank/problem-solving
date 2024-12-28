namespace ProblemSolving.ArrayDS;

internal class E_MaximumSubarray
{
    /*
     * Sliding window  - 
     * Kadane's algorithm is used to find the maximum sum sub array (when -ve sum is encountered we rest it o)
     * Kadane's algorithm is a dynamic programming algorithm which is used to find the maximum sum of a subarray from a given array
     */

    /// <summary>
    /// Brute force - Time Complexity - O(n2) Space Complexity - O(1)
    /// </summary>
    /// <returns>Max sum of  sub Array</returns>
    public static int MaximumSubArrayBruteForce()
    {
        int[] arr = [-2, 1, -3, 4, -1, 2, 1, -5, 4];
        int maxSum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            int curSum = 0;
            for (int j = i; j < arr.Length; j++)
            {
                curSum += arr[j];
                maxSum = Math.Max(maxSum, curSum);
            }
        }
        return maxSum;
    }

    /// <summary>
    /// Kadane's algorithm - Time Complexity - O(n) Space Complexity - O(1)
    /// </summary>
    /// <returns>Max sum of sub Array</returns>
    public static int MaximumSubarray()
    {
        int[] arr = [-2, 1, -3, 4, -1, 2, 1, -5, 4];
        int maxSum = arr[0];
        int curSum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            curSum += arr[i];
            maxSum = Math.Max(maxSum, curSum);

            if (curSum < 0) // if condition is added after maxSum calculation because if the input array is completely -ve then we need atleast one element to be considered
                curSum = 0;
        }
        return maxSum;
    }
}
