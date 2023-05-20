using LeetCode;
using Xunit;

namespace Tests
{
    public class _0005_LongestPalindromicSubstringTest
    {
        _0005_LongestPalindromicSubstring solution = new _0005_LongestPalindromicSubstring();

        [Fact]
        public void Test_Odd()
        {
            string result = solution.LongestPalindrome("babad");
            Assert.Equal("bab", result);
        }

        [Fact]
        public void Test_Even()
        {
            string result = solution.LongestPalindrome("cbbd");
            Assert.Equal("bb", result);
        }

        [Fact]
        public void Test_OneCharacter()
        {
            string result = solution.LongestPalindrome("a");
            Assert.Equal("a", result);
        }

        [Fact]
        public void Test_TwoCharacter2()
        {
            string result = solution.LongestPalindrome("11");
            Assert.Equal("11", result);
        }
    }
}
