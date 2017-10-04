using System;
using System.Collections.Generic;

namespace algorithms
{
    public class Solution001
    {
        public static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] answer = new Solution001().TwoSum(nums, target);
            Console.WriteLine("[{0}]", string.Join(", ", answer));
        }

        // One-pass using Dictionary
        public int[] TwoSum(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }

                map[nums[i]] = i;
            }

            // If no return yet, there is no solution.
            throw new System.ArgumentException("No solution");
        }
    }
}