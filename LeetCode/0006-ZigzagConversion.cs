// Link : https://leetcode.com/problems/zigzag-conversion/submissions/954073109/
// Runtime: 85 ms, faster than 85.58% of C# online submissions for Template.
// Memory Usage: 44.3 MB, less than 74.43% of C# online submissions for Template.

namespace LeetCode
{
    public class _0006_ZigzagConversion
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1) return s;

            char[] result = new char[s.Length];
            int i = 0;
            for (int j = 0; j < numRows; j++)
            {
                bool isFirstStep = false;
                int first = (numRows - j - 1) * 2;
                int second = j * 2;
                int[] steps = { first != 0 ? first : second, second != 0 ? second : first };
                for (int k = j; k < s.Length; k += steps[isFirstStep ? 0 : 1])
                {
                    isFirstStep = !isFirstStep;
                    result[i] = s[k];
                    i++;
                }
            }
            return new String(result);
        }
    }
}
