// Link : https://leetcode.com/problems/longest-palindromic-substring/submissions/954033482/
// Runtime: 316 ms, faster than 33.90% of C# online submissions for Longest Palindromic Substring.
// Memory Usage: 55.6 MB, less than 16.48% of C# online submissions for Longest Palindromic Substring.

namespace LeetCode
{
    public class _0005_LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            string longestPalindrome = "";
            string current = String.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                current = s[i].ToString();
                // Odd
                for (int j = 1; j < s.Length - i && j <= i; j++)
                {
                    if (s[i - j] == s[i + j])
                        current = s.Substring(i - j, (i + j) - (i - j) + 1);
                    else break;
                }
                if (current.Length > longestPalindrome.Length)
                    longestPalindrome = current.ToString();

                // Even
                if (i + 1 < s.Length && s[i] == s[i + 1])
                {
                    for (int j = 0; j < s.Length - i - 1 && j <= i; j++)
                    {
                        if (s[i - j] == s[i + j + 1])
                            current = s.Substring(i - j, (i + j) - (i - j) + 2);
                        else break;
                    }
                    if (current.Length > longestPalindrome.Length)
                        longestPalindrome = current.ToString();
                }
            }

            return longestPalindrome;
        }
    }
}
