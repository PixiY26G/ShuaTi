namespace hot_链表_反转列表
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

    }
    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            List<ListNode> nodes = new();
            ListNode head2 = head;
            while (head2 != null)//将链表存入list
            {
                //ListNode indexNode = new ListNode();
                //indexNode.next = head2;
                nodes.Add(head2);
                head2 = head2.next;

            }
            //ListNode retNode = nodes.Last();
            //head = retNode;
            //for (int i = nodes.Count - 1; i >= 0; i--)
            //{
            //    retNode.next = nodes[i].next;
            //    retNode = retNode.next;
            //}
            for (int i = nodes.Count - 1; i > 0; i++)
            {
                nodes[i].next = nodes[i - 1];
            }
            nodes[0].next = null;
            return nodes[nodes.Count - 1];
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
    public class Solution2//递归
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode second = head.next;
            ListNode newHead = ReverseList(second);
            second.next = head;
            head.next = null;
            return newHead;
        }
    }
    public class Solution3//迭代
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null, curr = head;
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
