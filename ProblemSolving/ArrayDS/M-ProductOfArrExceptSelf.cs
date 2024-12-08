namespace ProblemSolving.ArrayDS;

// https://leetcode.com/problems/product-of-array-except-self/description/
//  O(n) time and without using the division operation.
internal class E_ProductOfArrExceptSelf
{

    public static int[] ProductOfArray()
    {
        int[] arr = [1, 2, 3, 4];

        int n = arr.Length;
        int[] output = new int[n];

        // Calculate prefix products
        int prefix = 1;
        for (int i = 0; i < n; i++)
        {
            output[i] = prefix;
            prefix *= arr[i];
        }

        // Calculate suffix products and update the output array
        int suffix = 1;
        for (int i = n - 1; i >= 0; i--)
        {
            output[i] *= suffix;
            suffix *= arr[i];
        }

        return output;
    }
}
