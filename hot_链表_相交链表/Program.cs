namespace hot_链表_相交链表
{
    //给你两个单链表的头节点 headA 和 headB ，请你找出并返回两个单链表相交的起始节点。如果两个链表不存在相交节点，返回 null 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }


    }
    public class Solution
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
            {
                return null;
            }
            ListNode currentA = headA;
            HashSet<ListNode> visited = new();
            while (currentA != null)
            {
                visited.Add(currentA);
                currentA = currentA.next;
            }
            ListNode currentB = headB;
            while (currentB != null)
            {
                if (visited.Contains(currentB))
                {
                    return currentB;
                }
                currentB = currentB.next;
            }
            return null;
        }
        public ListNode GetIntersectionNode2(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
            {
                return null;
            }
            ListNode pA = headA, pB = headB;
            while (pA != pB)
            {
                pA = pA == null ? headB : pA.next;
                pB = pB == null ? headA : pB.next;
            }
            return pA;
        }

    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}




//
