// Link: https://leetcode.com/problems/add-two-numbers/submissions/953995801/
// Runtime: 93 ms, faster than 82.99% of C# online submissions for Add Two Numbers.
// Memory Usage: 49.6 MB, less than 23.97% of C# online submissions for Add Two Numbers.

using System.Numerics;

namespace LeetCode
{
    public class _0002_AddTwoNumbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            BigInteger total = GetNumber(l1) + GetNumber(l2);
            return GetNode(total) ?? new ListNode(0, null);
        }

        public BigInteger GetNumber(ListNode? node)
        {
            if (node == null)
                return 0;
            return GetNumber(node.next) * 10 + node.val;
        }

        public ListNode? GetNode(BigInteger value)
        {
            if (value == 0)
                return null;
            return new ListNode((int)(value % 10), GetNode(value / 10));
        }
    }
}
