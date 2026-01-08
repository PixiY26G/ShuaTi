namespace hot_数组_最大子数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [-2, 1, -3, 4, -1, 2, 1, -5, 4];
            Solution s = new();
            int a1 = s.MaxSubArray(nums);
            Console.WriteLine(a1);
        }
    }
    public class Solution
    {
        public int MaxSubArray(int[] nums)
        {
            if (nums == null)
            {
                return 0;
            }

            int ans = nums[0];
            #region 超时算法 O(n2)
            //for (int i = 0; i < nLen; i++)
            //{
            //    int index = 0;
            //    for (int j = i; j < nLen; j++)
            //    {
            //        index += nums[j];
            //        ans = Math.Max(ans, index);
            //    }
            //}            //将数组的元素存入字典，且大于零的为true，其余为false
            //Dictionary<int, bool> ints = new();
            //int nLen = nums.Length;
            //for (int i = 0; i < nLen; i++)
            //{
            //    if (nums[i] >= 0)
            //    {
            //        ints.Add(i, true);

            //    }
            //    else
            //    {
            //        ints.Add(i, false);
            //    }
            //}
            #endregion
            //方法一：动态规划
            int pre = 0, maxAns = nums[0];
            foreach (int x in nums)
            {
                pre = Math.Max(pre + x, x);
                maxAns = Math.Max(maxAns, pre);
            }
            return maxAns;


        }
        public int maxSubArray1(int[] nums)
        {
            int left = 0;
            int sum = nums[0];
            int maxSum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                // 如果你前面的累计 sum 都小于 0 了，说明没有增益。
                while (sum < 0)
                {
                    sum -= nums[left++];
                }
                sum += nums[i];
                maxSum = Math.Max(maxSum, sum);
            }
            return maxSum;
        }
    }
}
