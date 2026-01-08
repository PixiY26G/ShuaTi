namespace hot_技巧_多数元素
{
    //    给定一个大小为 n 的数组 nums ，返回其中的多数元素。多数元素是指在数组中出现次数 大于 ⌊ n/2 ⌋ 的元素。
    //你可以假设数组是非空的，并且给定的数组总是存在多数元素。
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [2, 2, 1, 1, 1, 2, 2];
            Solution s = new();
            int i = s.MajorityElement(nums);
            Console.WriteLine(i);
        }
        public class Solution
        {
            public int MajorityElement(int[] nums)
            {
                Dictionary<int, int> pairs = new();
                int n = nums.Length;
                for (int i = 0; i < n; i++)
                {
                    if (!pairs.ContainsKey(nums[i]))
                    {
                        pairs.Add(nums[i], 1);
                    }
                    else
                    {
                        pairs[nums[i]]++;
                    }
                }
                int index = 0;
                int ret = 0;
                foreach (var item in pairs)
                {
                    if (item.Value > index)
                    {
                        index = item.Value;
                        ret = item.Key;
                    }
                }
                return ret;
            }
        }//找最多数

        //答案：字典、排序、随机化、分治
        public int Ans1(int[] nums)//排序、由于是众数、且数量超过1/2。所以排序后的中位数就是众数
        {
            Array.Sort(nums);
            return nums[nums.Length / 2];
        }
        //public int Ans2(int[] nums)
        //{

        //}
    }
}
