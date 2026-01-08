namespace hot_技巧_只出现一次的数字
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
        public int SingleNumber(int[] nums)
        {
            Dictionary<int, bool> pairs = new();
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                if (!pairs.ContainsKey(nums[i]))
                {
                    pairs.Add(nums[i], false);
                }
                else
                {
                    pairs[nums[i]] = true;
                }
            }
            foreach (var item in pairs)
            {
                if (item.Value == false)
                {
                    return item.Key;
                }
            }
            return 0;
        }
        public int Ans(int[] nums)
        {
            int ret = 0;
            foreach (var item in nums)
            {
                ret ^= item;
            }
            return ret;
        }
    }
}
