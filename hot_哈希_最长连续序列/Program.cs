using System.Reflection.Metadata;

namespace hot_哈希_最长连续序列
{
    //给定一个未排序的整数数组 nums ，找出数字连续的最长序列（不要求序列元素在原数组中连续）的长度。
    //请你设计并实现时间复杂度为 O(n) 的算法解决此问题。
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new();
            int[] nums = [100, 4, 200, 1, 3, 2];
            Console.WriteLine(s.LongestConsecutive(nums));
        }
    }
    public class Solution
    {
        public int LongestConsecutive(int[] nums)
        {
            //Array.Sort(nums);
            //int ans = 0;
            #region My
            //List<int> numsList = new();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    numsList.Add(nums[i]);
            //}

            //for (int i = 0; i < numsList.Count; i++)
            //{
            //    int x = numsList[i];
            //    if (numsList.Contains(x - 1))
            //    {
            //        continue;
            //    }
            //    int y = x + 1;
            //    while (numsList.Contains(y))
            //    {
            //        y++;
            //    }
            //    ans = Math.Max(ans, y - x);
            //}
            #endregion
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            HashSet<int> numSet = new HashSet<int>(nums);
            int longest = 0;
            foreach (var num in numSet)
            {
                if (!numSet.Contains(num - 1))
                {
                    int currentNum = num;
                    int currentLenght = 1;
                    while (numSet.Contains(currentNum + 1))
                    {
                        currentNum++;
                        currentLenght++;
                    }
                    longest = Math.Max(longest, currentLenght);
                }
            }

            return longest;
        }

        public int LongestConsecutive2(int[] nums)
        {
            HashSet<int> st = new(nums);
            int ans = 0;
            foreach (int x in st)
            {

                if (st.Contains(x - 1))
                {
                    continue;
                }
                int y = x + 1;
                while (st.Contains(y))
                {
                    y++;
                }
                ans = Math.Max(ans, y - x);
            }
            return ans;
        }
    }
}
