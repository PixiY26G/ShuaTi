namespace hot_42_接雨水
{
    //给定 n 个非负整数表示每个宽度为 1 的柱子的高度图，计算按此排列的柱子，下雨之后能接多少雨水。
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new();
            int[] nums = [0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1];
            Console.Write(s.Trap(nums));
        }

    }
    public class Solution
    {
        public int Trap(int[] heights)
        {
            if (heights.Length <= 2)
            {
                return 0;
            }
            int wall = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                wall += heights[i];
            }
            int sum = 0;
            int left = 0;
            int right = heights.Length - 1;
            int h = 1;
            while (left <= right)
            {
                while (left <= right && heights[left] < h)
                {
                    left++;
                }
                while (left <= right && heights[right] < h)
                {
                    right--;
                }
                if (left <= right)
                {
                    sum += (right - left + 1);
                    h++;
                }

            }
            return sum - wall;
        }
    }
}
