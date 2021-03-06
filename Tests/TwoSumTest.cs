using System;
using LeetCode.TwoSum;
using Xunit;

namespace Tests
{
    public class TwoSumTest
    {
        Solution solution = new Solution();

        [Fact]
        public void Test_Example1()
        {
            int[] result = solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            Assert.Equal(new int[] { 0, 1 }, result);
        }

        [Fact]
        public void Test_Example2()
        {
            int[] result = solution.TwoSum(new int[] { 3, 2, 4 }, 6);
            Assert.Equal(new int[] { 1, 2 }, result);
        }

        [Fact]
        public void Test_Example3()
        {
            int[] result = solution.TwoSum(new int[] { 3, 3 }, 6);
            Assert.Equal(new int[] { 0, 1 }, result);
        }
    }
}