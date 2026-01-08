namespace hot_数组_第一个缺失的正数
{
    //给你一个未排序的整数数组 nums ，请你找出其中没有出现的最小的正整数。
    //请你实现时间复杂度为 O(n) 并且只使用常数级别额外空间的解决方案。
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new();
            int[] nums = [1, 1];
            int w = s.FirstMissingPositive(nums);
            Console.WriteLine(w);
        }
        public class Solution
        {
            public int FirstMissingPositive(int[] nums)
            {
                int ans = 1;
                int nLen = nums.Length;
                //if (nLen == 1 && nums[0] == 1)
                //{
                //    return ans;
                //}
                //Dictionary<int, int> ints = new();
                //for (int i = 0; i < nLen; i++)
                //{
                //    if (!ints.ContainsKey(nums[i]))
                //    {
                //        ints.Add(nums[i], i);
                //    }

                //}
                //for (int i = 0; i < nums.Length; i++)
                //{
                //    if (i < nLen && !ints.ContainsKey(ans))
                //    {
                //        return ans;
                //    }
                //    else if (i < nLen && ints.ContainsKey(ans))
                //    {
                //        ans++;
                //    }
                //}
                Array.Sort(nums);
                for (int i = 0; i < nLen; i++)
                {
                    Math.Max(ans, nums[i]);
                }
                return ans + 1;
            }
        }
    }
}
