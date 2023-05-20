// Link : https://leetcode.com/problems/longest-substring-without-repeating-characters/submissions/953994520/
// Runtime: 64 ms, faster than 93.89% of C# online submissions for Longest Substring Without Repeating Characters.
// Memory Usage: 39.9 MB, less than 56.93% of C# online submissions for Longest Substring Without Repeating Characters.

using System.Text;

namespace LeetCode
{
    public class _0003_LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            int maxLength = 0;
            StringBuilder sb = new StringBuilder();
            Dictionary<char, bool> found = new Dictionary<char, bool>();
            for (int i = 0; i < s.Length; i++)
            {
                if (found.ContainsKey(s[i]))
                {
                    maxLength = Math.Max(sb.Length, maxLength);
                    for (int j = 0; j < sb.Length; j++)
                    {
                        found.Remove(sb[j]);
                        if (sb[j] == s[i])
                        {
                            sb.Remove(0, j + 1);
                            break;
                        }
                    }
                }
                sb.Append(s[i]);
                found.Add(s[i], true);
            }
            maxLength = Math.Max(sb.Length, maxLength);
            return maxLength;
        }
    }
}
