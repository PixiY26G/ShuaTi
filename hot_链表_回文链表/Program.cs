using System.Runtime.InteropServices;

namespace hot_链表_回文链表
{
    //给你一个单链表的头节点 head ，请你判断该链表是否为回文链表。如果是，返回 true ；否则，返回 false 。
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
        }

    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class Solution2
    {
        public bool IsPalindrome(ListNode head)
        {
            ListNode headNode2 = head;
            List<ListNode> nodes = new();
            while (headNode2 != null)
            {
                nodes.Add(headNode2);
                headNode2 = headNode2.next;
            }
            int n = nodes.Count;
            for (int i = 0; i < (n + 1) / 2; i++)
            {
                if (nodes[i].val != nodes[n - 1 - i].val)
                {
                    return false;
                }
            }
            return true;
        }
    }
    public class Solution
    {
        public bool IsPalindrome(ListNode head)
        {
            if (head == null)
            {
                return true;
            }
            ListNode nodeFast = head;
            ListNode nodeSlow = head;
            while (nodeFast.next != null && nodeFast.next.next != null)
            {
                nodeFast = nodeFast.next.next;
                nodeSlow = nodeSlow.next;
            }

            bool res = true;
            ListNode p1 = head;
            ListNode p2 = reverseList(nodeSlow.next);
            ListNode p3 = p2;
            while (res && p2 != null)
            {
                if (p1.val != p2.val)
                {
                    res = false;
                    //return res; 要还原链
                }
                p1 = p1.next;
                p2 = p2.next;
            }
            nodeSlow.next = reverseList(p3);
            return res;
        }
        public ListNode reverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;
            while (curr != null)
            {
                ListNode next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            return prev;
        }
    }
}
