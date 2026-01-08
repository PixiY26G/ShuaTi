namespace hot_双指针_三数之和
{
    //给你一个整数数组 nums ，判断是否存在三元组[nums[i], nums[j], nums[k]] 满足 i != j、i != k 且 j != k ，
    //同时还满足 nums[i] + nums[j] + nums[k] == 0 。请你返回所有和为 0 且不重复的三元组。
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new();
            s.ThreeSum([-1, 0, 1, 2, -1, -4]);
        }
    }
    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            List<IList<int>> ans = new();
            Array.Sort(nums);
            int n = nums.Length;
            if (nums.Length <= 2 || nums == null)
            {
                return ans;
            }
            for (int i = 0; i < n - 2; i++)
            {
                //当目前的数大于0，之后的数都大于0
                if (nums[i] > 0)
                {
                    break;
                }
                //去重
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                int L = i + 1;
                int R = n - 1;
                while (L < R)
                {
                    int sum = nums[i] + nums[L] + nums[R];
                    if (sum == 0)
                    {
                        ans.Add(new List<int> { nums[i], nums[L], nums[R] });
                        //ints.Add(nums[i]);
                        //ints.Add(nums[L]);
                        //ints.Add(nums[R]);
                        //ans.Add(ints);
                        while (L < R && nums[L] == nums[L + 1])
                        {
                            L++;
                        }
                        while (L < R && nums[R] == nums[R - 1])
                        {
                            R--;
                        }
                        L++;
                        R--;
                    }
                    else if (sum < 0)
                    {
                        L++;
                    }
                    else if (sum > 0)
                    {
                        R--;
                    }

                }

            }
            //PrintResult(ans);
            return ans;
        }
        private void PrintResult(IList<IList<int>> result)
        {
            Console.WriteLine("三数之和为0的结果：");
            foreach (var list in result)
            {
                foreach (var num in list)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"总计: {result.Count} 组");
            //    foreach (var list in ans)
            //        {
            //            foreach (var num in list)
            //            {
            //                Console.Write(num + " ");
            //            }
            //Console.WriteLine(" ");
            //}
        }

    }
}
