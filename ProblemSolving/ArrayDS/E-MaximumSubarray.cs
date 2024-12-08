namespace ProblemSolving.ArrayDS;

internal class E_MaximumSubarray
{
    /*
     * Sliding window 
     */

    public static int MaximumSubarray()
    {
        int[] arr = [-2, 1, -3, 4, -1, 2, 1, -5, 4];
        int maxSum = arr[0];
        int curSum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (curSum < 0)
                curSum = 0;
            curSum += arr[i];
            maxSum = Math.Max(maxSum, curSum);

        }
        return maxSum;

    }
}
