namespace ProblemSolving.ArrayDS;

internal class E_ContainsDuplicate
{
    /// <summary>
    /// Time Complexity - O(n) SpaceComplexity - O(n)
    /// </summary>
    public static bool ContainsDuplicate()
    {
        int[] arr = [1, 2, 3, 1];
        HashSet<int> set = [];

        for (int i = 0; i < arr.Length; i++)
        {
            if (set.Contains(arr[i])) return true;
            set.Add(arr[i]);
        }
        return false;
    }
}
