using System.Numerics;

namespace LeetCode
{
    namespace AddTwoNumbers
    {
        public class ListNode
        {
            public int val;
            public ListNode? next;
            public ListNode(int val = 0, ListNode? next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public class Solution
        {
            // Runtime: 100 ms, faster than 91.01% of C# online submissions for Add Two Numbers.
            // Memory Usage: 28.6 MB, less than 9.14% of C# online submissions for Add Two Numbers.
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
}
