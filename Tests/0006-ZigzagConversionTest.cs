using LeetCode;
using Xunit;

namespace Tests
{
    public class _0006_ZigzagConversionTest
    {
        _0006_ZigzagConversion solution = new _0006_ZigzagConversion();

        [Fact]
        public void Test_ThreeRows()
        {
            string result = solution.Convert("PAYPALISHIRING", 3);
            Assert.Equal("PAHNAPLSIIGYIR", result);
        }

        [Fact]
        public void Test_FourRows()
        {
            string result = solution.Convert("PAYPALISHIRING", 4);
            Assert.Equal("PINALSIGYAHRPI", result);
        }

        [Fact]
        public void Test_OneCharacter()
        {
            string result = solution.Convert("A", 1);
            Assert.Equal("A", result);
        }
    }
}
