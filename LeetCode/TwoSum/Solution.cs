using System;
using System.Collections.Generic;

namespace LeetCode
{
    namespace TwoSum
    {
        public class Solution
        {
            // Runtime: 244 ms, faster than 81.57% of C# online submissions for Two Sum.
            // Memory Usage: 32.8 MB, less than 22.08% of C# online submissions for Two Sum.
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
