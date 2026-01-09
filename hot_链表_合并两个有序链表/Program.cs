namespace hot_链表_合并两个有序链表
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
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null)
            {
                return list2;
            }
            if (list2 == null)
            {
                return list1;
            }

            ListNode ret = new();
            var nodes = ret;
            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {

                    nodes.next = list1;
                    list1 = list1.next;

                }
                else
                {

                    nodes.next = list2;
                    list2 = list2.next;

                }
                nodes = nodes.next;
            }

            if (list1 != null)
            {
                nodes.next = list1;
            }
            if (list2 != null)
            {
                nodes.next = list2;
            }


            return ret.next;
        }
        public ListNode MergeTwoLists2(ListNode list1, ListNode list2)
        {
            if (list1 == null) return list2;
            if (list2 == null) return list1;

            if (list1.val < list2.val)
            {
                list1.next = MergeTwoLists2(list1.next, list2);
                return list1;
            }
            else
            {
                list2.next = MergeTwoLists2(list1, list2.next);
                return list2;
            }
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
}
