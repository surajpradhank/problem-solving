namespace ProblemSolving.ArrayDS
{
    public static class TwoSum
    {
        /// <summary>
        /// Time Complexity - O(n2) Space Complexity - O(1)
        /// </summary>
        public static int[] CalculateTwoSum(int[] array, int sum)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if ((array[i] + array[j]) == sum)
                        return [array[i], array[j]];
                }
            }
            return [];
        }

        /// <summary>
        /// Time Complexity - O(n) Space Complexity - O(n)
        /// </summary>
        public static int[] CalculateTwoSumOption2(int[] array, int sum)
        {
            HashSet<int> keyValues = new HashSet<int>();
            for (int i = 0; i < array.Length; i++)
            {
                int remainingSum = sum - array[i];

                if (keyValues.Contains(remainingSum))
                {
                    return [array[i], remainingSum];
                }
                keyValues.Add(array[i]);
            }
            return array;

        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="aray"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public static int[] CalculateTwoSumOption3(int[] array, int sum)
        {
            return new int[] { };
        }
    }
}
