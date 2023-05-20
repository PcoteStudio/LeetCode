using LeetCode;
using Xunit;

namespace Tests
{
    public class _0001_TwoSumTest
    {
        _0001_TwoSum solution = new _0001_TwoSum();

        [Fact]
        public void Test_SumIncludesIndice0()
        {
            int[] result = solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            Assert.Equal(new int[] { 0, 1 }, result);
        }

        [Fact]
        public void Test_SumIncludesLastIndice()
        {
            int[] result = solution.TwoSum(new int[] { 3, 2, 4 }, 6);
            Assert.Equal(new int[] { 1, 2 }, result);
        }

        [Fact]
        public void Test_TargetIsSumOfSameTerms()
        {
            int[] result = solution.TwoSum(new int[] { 3, 3 }, 6);
            Assert.Equal(new int[] { 0, 1 }, result);
        }

        [Fact]
        public void Test_InputHasManyIdenticalNumbers()
        {
            int[] result = solution.TwoSum(new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 }, 11);
            Assert.Equal(new int[] { 5, 11 }, result);
        }
    }
}