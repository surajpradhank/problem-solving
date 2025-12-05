using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.ArrayDS
{
    internal class M_SubArrayEqualsOut
    {
        public int SubarraySum()
        {
            int[] nums = [1, 2, 3];
            int k = 3;

            var prefixSumCounts = new Dictionary<int, int>();
            prefixSumCounts[0] = 1; // Base case: sum of 0 occurs once

            int currentSum = 0;
            int count = 0;

            foreach (var num in nums)
            {
                currentSum += num;

                // Check if there's a prefix sum that makes currentSum - k
                if (prefixSumCounts.ContainsKey(currentSum - k))
                {
                    count += prefixSumCounts[currentSum - k];
                }

                // Update the prefix sum count
                if (!prefixSumCounts.ContainsKey(currentSum))
                    prefixSumCounts[currentSum] = 0;

                prefixSumCounts[currentSum]++;
            }

            return count;
        }
        public void SubArrayEqualsResult()
        {
            int[] arr = [1, 2, 3];
            int k = 3;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int sum = 0;
                for (int j = i ; j < arr.Length; j++)
                {
                    sum += arr[j];
                    if (sum == k)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("Output " + count);
        }
    }
}
