namespace ProblemSolving.Algorithm;

public class BinarySearch
{

    #region Recursion

    public int BinarySearchHelperRecursive(int[] input, int value, int low, int high)
    {

        if (low > high)
            return -1;

        if (high >= low)
        {
            int mid = low + (high - low) / 2;

            if (input[mid] == value)
                return mid;

            if (value < input[mid])
                return BinarySearchHelperRecursive(input, value, low, mid - 1);

            return BinarySearchHelperRecursive(input, value, mid + 1, high);
        }

        return -1;
    }

    #endregion

    #region Iterative
    /// <summary>
    ///     Finds index of item in array that equals to item searched for
    ///     Time complexity: O(log(n))
    ///     Space complexity: O(1)
    /// </summary>
    /// <param name="input">Sorted array to search in.</param>
    /// <param name="value">Item to search for.</param>
    /// <returns>Index of item that equals to item searched for or -1 if none found.</returns>

    public int binarySearchHelperIterative(int[] input, int value)
    {
        int low = 0, mid = 0;
        int high = input.Length - 1;

        while (low <= high)
        {
            mid = low + ((high - low) / 2);

            if (input[mid] == value)
                return mid;

            else if (value < input[mid])
                high = mid - 1;

            else
                low = mid + 1;
        }

        return -1;
    }

    #endregion

}
