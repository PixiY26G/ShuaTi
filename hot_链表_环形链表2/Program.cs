using System.ComponentModel.DataAnnotations;

namespace hot_链表_环形链表2
{
    //    给定一个链表的头节点 head ，返回链表开始入环的第一个节点。 如果链表无环，则返回 null。
    //如果链表中有某个节点，可以通过连续跟踪 next 指针再次到达，则链表中存在环。 为了表示给定链
    //表中的环，评测系统内部使用整数 pos 来表示链表尾连接到链表中的位置（索引从 0 开始）。如果 pos 是 -1，则在该链表中没有环。
    //注意：pos 不作为参数进行传递，仅仅是为了标识链表的实际情况。
    //不允许修改 链表。
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    //节点
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

    public class Solution1
    {
        public ListNode DetectCycle(ListNode head)
        {
            if (head == null)
            {
                return head;
            }
            Dictionary<ListNode, bool> nodes = new();
            ListNode p1 = head;
            while (p1 != null && p1.next != null)
            {

                if (nodes.ContainsKey(p1))
                {
                    return p1;
                }
                if (!nodes.ContainsKey(p1))
                {
                    nodes.Add(p1, false);
                }
                p1 = p1.next;
            }
            return null;
        }
    }
    public class Solution
    {
        public ListNode DetectCycle(ListNode head)
        {
            if (head == null)
            {
                return head;
            }
            ListNode fast = head;
            ListNode slow = head;
            while (fast != null && fast.next != null && fast.next.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
                if (fast != slow)
                {
                    continue;
                }
                var catcher = head;
                while (catcher != slow)
                {
                    catcher = catcher?.next;
                    slow = slow?.next;
                }
            }

            return null;
        }
    }
}
