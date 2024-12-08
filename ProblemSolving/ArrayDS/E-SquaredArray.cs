namespace ProblemSolving.ArrayDS;

internal static class SquaredArray
{
    /// <summary>
    /// Time Complexity - O(nlogn) SpaceComplexity - O(n)
    /// </summary>
    public static int[] SortedSquaredArray(int[] arr)
    {
        int[] result = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            result[i] = (int)Math.Pow(arr[i], 2);
        }

        Array.Sort(result);
        return result;
    }


    /// <summary>
    /// Time Complexity - O(n) Space Compelxiity - O(n)
    /// There might be scenraio of -ve no so have go for absolute check
    /// </summary>
    public static int[] SortedSquaredArrayOption2(int[] arr)
    {
        int[] result = new int[arr.Length];

        int left = 0, right = arr.Length - 1;

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            int smallerValue = arr[left];
            int largerValue = arr[right];

            if (Math.Abs(smallerValue) > Math.Abs(largerValue))
            {
                result[i] = smallerValue * smallerValue;
                left++;
            }
            else
            {
                result[i] = largerValue * largerValue;
                right--;
            }
        }

        return result;
    }


}
