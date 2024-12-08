namespace ProblemSolving.Concepts;

public static class SlidingWindow
{
    /**
     * Brute Force - loop twice( for i loop, then for j = i;j<i+k(window size) loop )
     
     * How to identify
        = (array and string question) + (sub array/sub string) + (largest/maximum) + (k = window size(optional))

      Fixed size = window size is given
     
      Variable = find window size, normally sum is given

     **/

    #region Fixed Window

    public static int MaximumSumSubArray() // Time = O(n) Space = 0(1)
    {
        int[] arr = [2, 5, 1, 8, 2, 9, 1];
        int k = 3;//window size
        int n = arr.Length;

        // first window sum of size k

        int maxSum = 0;
        for (int i = 0; i < k; i++)
            maxSum = maxSum + arr[i];

        int windowSum = maxSum;
        for (int i = k; i < n; i++)
        {
            windowSum = windowSum + arr[i] - arr[i - k];
            maxSum = Math.Max(maxSum, windowSum);
        }

        return maxSum;
    }

    #endregion 
}
