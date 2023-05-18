using LeetCode;
using System.Numerics;
using Xunit;

namespace Tests
{
    public class _0002_AddTwoNumbersTest
    {
        _0002_AddTwoNumbers solution = new _0002_AddTwoNumbers();

        [Fact]
        public void Test_SameDepth()
        {
            ListNode? l1 = new ListNode(3, null);
            l1 = new ListNode(4, l1);
            l1 = new ListNode(2, l1);

            ListNode? l2 = new ListNode(4, null);
            l2 = new ListNode(6, l2);
            l2 = new ListNode(5, l2);

            ListNode result = solution.AddTwoNumbers(l1, l2);
            Assert.Equal(new BigInteger(807), solution.GetNumber(result));
        }

        [Fact]
        public void Test_AddZero()
        {
            ListNode? l1 = new ListNode(0, null);

            ListNode? l2 = new ListNode(0, null);

            ListNode result = solution.AddTwoNumbers(l1, l2);
            Assert.Equal(new BigInteger(0), result.val);
            Assert.Null(result.next);
        }

        [Fact]
        public void Test_DifferentDepth()
        {
            ListNode? l1 = new ListNode(9, null);
            l1 = new ListNode(9, l1);
            l1 = new ListNode(9, l1);
            l1 = new ListNode(9, l1);
            l1 = new ListNode(9, l1);
            l1 = new ListNode(9, l1);
            l1 = new ListNode(9, l1);

            ListNode? l2 = new ListNode(9, null);
            l2 = new ListNode(9, l2);
            l2 = new ListNode(9, l2);
            l2 = new ListNode(9, l2);

            ListNode result = solution.AddTwoNumbers(l1, l2);
            Assert.Equal(new BigInteger(10009998), solution.GetNumber(result));
        }

        [Fact]
        public void Test_NumberLargerThanLong()
        {
            ListNode? l1 = new ListNode(9, null);

            ListNode? l2 = new ListNode(9, null);
            l2 = new ListNode(9, l2);
            l2 = new ListNode(9, l2);
            l2 = new ListNode(9, l2);
            l2 = new ListNode(9, l2);
            l2 = new ListNode(9, l2);
            l2 = new ListNode(9, l2);
            l2 = new ListNode(9, l2);
            l2 = new ListNode(9, l2);
            l2 = new ListNode(9, l2);
            l2 = new ListNode(9, l2);
            l2 = new ListNode(9, l2);
            l2 = new ListNode(9, l2);
            l2 = new ListNode(9, l2);
            l2 = new ListNode(9, l2);
            l2 = new ListNode(9, l2);
            l2 = new ListNode(9, l2);
            l2 = new ListNode(9, l2);
            l2 = new ListNode(9, l2);
            l2 = new ListNode(9, l2);
            l2 = new ListNode(9, l2);
            l2 = new ListNode(9, l2);
            l2 = new ListNode(9, l2);
            l2 = new ListNode(9, l2);
            l2 = new ListNode(1, l2);

            ListNode result = solution.AddTwoNumbers(l1, l2);
            Assert.Equal(BigInteger.Parse("10000000000000000000000000"), solution.GetNumber(result));
        }

        [Fact]
        public void Test_GetNumber()
        {
            ListNode? list = new ListNode(4, null);
            list = new ListNode(6, list);
            list = new ListNode(5, list);

            Assert.Equal(new BigInteger(465), solution.GetNumber(list));
        }

        [Fact]
        public void Test_GetNode()
        {
            ListNode? node = solution.GetNode(301);
            Assert.Equal(1, node?.val);
            Assert.Equal(0, node?.next?.val);
            Assert.Equal(3, node?.next?.next?.val);
            Assert.Null(node?.next?.next?.next);
        }
    }
}
