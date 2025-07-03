namespace T9_跳跃游戏
{
    public class Solution
    {
        public bool Ans(int[] nums)
        {
            int n = nums.Length;
            int max = 0;
            for (int i = 0; i < n; ++i)
            {
                if (i > max) return false;
                max = max > (nums[i] + i) ? max : (nums[i] + i);
                if (max >= n - 1)
                    return true;
            }
            return false;
        }
        public bool CanJump(int[] nums)
        {
            if (nums[0] == 0 && nums.Length > 1)
            {
                return false;
            }
            int large = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i <= large)
                {
                    large = large > (nums[i] + i) ? large : (nums[i] + i);
                }
                else
                {
                    return false;
                }
            }
            if (large >= nums.Length - 1)
            {
                return true;
            }
            return false;
        }
    }
    //给你一个非负整数数组 nums ，你最初位于数组的 第一个下标 。数组中的每个元素代表你在该位置可以跳跃的最大长度。判断你是否能够到达最后一个下标，如果可以，返回 true ；否则，返回 false 。


    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new();
            bool b1 = solution.CanJump([2, 3, 1, 1, 4]);
            Console.WriteLine(b1);
            bool b2 = solution.CanJump([3, 2, 1, 0, 4]);
            Console.WriteLine(b2);
            bool b3 = solution.CanJump([0]);
            Console.WriteLine(b3);
        }
    }
}
