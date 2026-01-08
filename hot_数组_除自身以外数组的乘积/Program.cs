namespace hot_数组_除自身以外数组的乘积
{
    //    给你一个整数数组 nums，返回 数组 answer ，其中 answer[i] 等于 nums 中除 nums[i] 之外其余各元素的乘积 。
    //题目数据 保证 数组 nums之中任意元素的全部前缀元素和后缀的乘积都在  32 位 整数范围内。
    //请 不要使用除法，且在 O(n) 时间复杂度内完成此题
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public class Solution
        {
            public int[] ProductExceptSelf(int[] nums)
            {
                int nLen = nums.Length;
                int[] ans = new int[nLen];
                int[] left = new int[nLen];
                int leftSum = 1;
                int[] right = new int[nLen];
                int rightSum = 1;
                //获得两个数组
                for (int i = 0; i < nLen; i++)
                {
                    left[i] = leftSum;
                    right[i] = rightSum;
                    leftSum *= nums[i];
                    rightSum *= nums[nLen - 1 - i];

                }
                for (int i = 0; i < nLen; i++)
                {
                    ans[i] = left[i] * right[nLen - 1 - i];
                }
                return ans;
            }
        }



    }
}
