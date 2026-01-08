namespace hot_技巧_寻找重复数
{
    //    给定一个包含 n + 1 个整数的数组 nums ，其数字都在[1, n] 范围内（包括 1 和 n），可知至少存在一个重复的整数。
    //假设 nums 只有 一个重复的整数 ，返回 这个重复的数 。
    //你设计的解决方案必须 不修改 数组 nums 且只用常量级 O(1) 的额外空间。
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class Solution
    {
        public int FindDuplicate(int[] nums)
        {
            HashSet<int> ints = new();
            int n = nums.Length;
            ints.Add(nums[0]);

            for (int i = 1; i < n; i++)
            {
                if (ints.Contains(nums[i]))
                {
                    return nums[i];
                }
                ints.Add(nums[i]);
            }
            return 0;
        }
    }
}
