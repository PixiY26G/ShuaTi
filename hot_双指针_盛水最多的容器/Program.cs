namespace hot_双指针_盛水最多的容器
{
    //    给定一个长度为 n 的整数数组 height 。有 n 条垂线，第 i 条线的两个端点是(i, 0) 和(i, height[i]) 。

    //找出其中的两条线，使得它们与 x 轴共同构成的容器可以容纳最多的水。

    //返回容器可以储存的最大水量。

    //说明：你不能倾斜容器。
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [1, 8, 6, 2, 5, 4, 8, 3, 7];
            Solution s = new();
            int ans = s.MaxArea(nums);
            Console.WriteLine(ans);
        }
    }
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int n = height.Length;
            int left = 0;
            int right = n - 1;
            int ans = 0;
            int max = 0;
            #region 超时，O(n2)
            //for (int i = 0; i < n; i++)
            //{
            //    left = i;
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        right = j;
            //        max = (right - left) * Math.Min(height[left], height[right]);
            //        ans = Math.Max(ans, max);
            //    }
            //}

            #endregion
            while (left <= right)
            {
                //当左比右小时，计算，并且让左++
                while (left <= right && height[left] <= height[right])
                {
                    max = (right - left) * Math.Min(height[left], height[right]);
                    ans = Math.Max(ans, max);
                    left++;
                }
                //当左比右大时，计算，并且让右--
                while (left <= right && height[left] > height[right])
                {
                    max = (right - left) * Math.Min(height[left], height[right]);
                    ans = Math.Max(ans, max);
                    right--;
                }
            }

            return ans;
        }
    }
}
