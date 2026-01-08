using System.Diagnostics;
using System.Reflection.Metadata;

namespace hot_1_两数之和
{
    //    给定一个整数数组 nums 和一个整数目标值 target，请你在该数组中找出 和为目标值 target 的那 两个 整数，并返回它们的数组下标。
    //    你可以假设每种输入只会对应一个答案，并且你不能使用两次相同的元素。
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = [2, 7, 11, 15];
            //int target = 9;
            int[] nums = [3, 3]; int target = 6;
            int[] nums2 = [3, 2, 4];
            Solution s = new();
            s.TwoSum(nums, target);
            s.TwoSum(nums2, target);
        }

    }
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] ret = new int[2];
            #region 超出时间限制
            //超出时间限制
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"i={i}   nums[i]={nums[i]}");
                for (int j = i + 1; j < nums.Length; j++)
                {
                    Console.WriteLine($"i={i}  j={j}  nums[i]={nums[i]}  nums[j]={nums[j]}");
                    if (nums[i] + nums[j] == target)
                    {
                        Console.WriteLine($"Find:  i={i}  j={j}  nums[i]={nums[i]}  nums[j]={nums[j]}");
                        ret[0] = i;
                        ret[1] = j;
                        return ret;
                    }
                }
            }

            #endregion
            return ret;
        }
        public int[] Ans(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (dic.ContainsKey(complement))
                {
                    return new int[] { dic[complement], i };
                }
                if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], i);
                }
            }
            return [];
        }
    }
}
