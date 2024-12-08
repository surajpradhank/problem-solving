
namespace ProblemSolving.ArrayDS
{
    internal static class SubSequence
    {
        /// <summary>
        /// Time Complexity - O(n2) and Space Complexity - O(n)
        /// </summary>
        public static bool ValidateSubSequence(int[] array, int[] sequence)
        {
            var sequenceLength = sequence.Length;
            var count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < sequence.Length; j++)
                {
                    if (array[i] == sequence[j])
                    {
                        count += 1;
                    }
                }
            }

            return count == sequenceLength;

        }

        /// <summary>
        /// Time Complexity - O(n) Space Complexity -O(1)
        /// </summary>
        public static bool ValidateSubSequenceOption2(int[] arr, int[] sequence)
        {
            int sequenceId = 0;
            foreach (var val in arr)
            {
                if (sequenceId == sequence.Length)
                    break;

                if (sequence[sequenceId] == val)
                    sequenceId += 1;

            }

            return sequenceId == sequence.Length;
        }

    }
}
