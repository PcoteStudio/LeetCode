// Link : https://leetcode.com/problems/two-sum/submissions/954003355/
// Runtime: 153 ms, faster than 72.61% of C# online submissions for Two Sum.
// Memory Usage: 44.8 MB, less than 20.74% of C# online submissions for Two Sum.

namespace LeetCode
{
    public class _0001_TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> found = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (target - nums[i] != nums[i] && found.ContainsKey(nums[i]))
                    continue;
                if (found.ContainsKey(target - nums[i]))
                    return new int[] { found[target - nums[i]], i };
                found.Add(nums[i], i);
            }
            throw new ArgumentException("No valid sum exist");
        }
    }
}
