using LeetCode;
using Xunit;

namespace Tests
{
    public class _0000_TemplateTest
    {
        _0000_Template solution = new _0000_Template();

        [Fact]
        public void Test_Example1()
        {
            int result = solution.Template();
            Assert.Equal(0, result);
        }
    }
}
