namespace hot_子串_合为k的子数组
{
    //    给你一个整数数组 nums 和一个整数 k ，请你统计并返回 该数组中和为 k 的子数组的个数 。

    //子数组是数组中元素的连续非空序列。
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [-1, -1, 1];
            int k = 0;
            Solution s = new();
            int ans = s.SubarraySum(nums, k);
            Console.WriteLine(ans);
        }
    }
    public class Solution
    {
        public int SubarraySum(int[] nums, int k)
        {
            if (nums == null)
            {
                return 0;
            }

            int ans = 0;//答案

            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                int index = 0;//子数组中的和
                for (int j = i; j < n; j++)
                {
                    index += nums[j];
                    if (index == k)
                    {
                        ans++;
                    }
                }
            }

            return ans;
        }
    }
}
