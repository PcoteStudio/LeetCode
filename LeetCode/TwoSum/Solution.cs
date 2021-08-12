using System;
using System.Collections.Generic;

namespace LeetCode
{
    namespace TwoSum
    {
        public class Solution
        {
            // Runtime: 252 ms, faster than 63.02% of C# online submissions for Two Sum.
            // Memory Usage: 32.9 MB, less than 17.31% of C# online submissions for Two Sum.
            public int[] TwoSum(int[] nums, int target)
            {
                Dictionary<int, int> complements = new Dictionary<int, int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    if (complements.ContainsKey(nums[i]))
                        return new int[] { complements[nums[i]], i };
                    complements.Add(target - nums[i], i);
                }
                throw new ArgumentException("No valid sum exist");
            }
        }
    }
}
