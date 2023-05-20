using LeetCode;
using Xunit;

namespace Tests
{
    public class _0003_LongestSubstringWithoutRepeatingCharactersTest
    {
        _0003_LongestSubstringWithoutRepeatingCharacters solution = new _0003_LongestSubstringWithoutRepeatingCharacters();

        [Fact]
        public void Test_Example1()
        {
            int result = solution.LengthOfLongestSubstring("abcabcbb");
            Assert.Equal(3, result);
        }

        [Fact]
        public void Test_Example2()
        {
            int result = solution.LengthOfLongestSubstring("bbbbb");
            Assert.Equal(1, result);
        }

        [Fact]
        public void Test_Example3()
        {
            int result = solution.LengthOfLongestSubstring("pwwkew");
            Assert.Equal(3, result);
        }
    }
}
