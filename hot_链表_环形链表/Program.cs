namespace hot_链表_环形链表
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }
        public class Solution
        {
            public bool HasCycle(ListNode head)
            {
                if (head == null)
                {
                    return false;
                }
                bool res = false;
                ListNode fast = head;
                ListNode slow = head;
                while (fast.next != null && fast.next.next != null && fast != null)
                {

                    if (fast == slow)
                    {
                        return true;
                    }
                    fast = fast.next.next;
                    slow = slow.next;
                }
                return false;
            }
        }
    }
}
