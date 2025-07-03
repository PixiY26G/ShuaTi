namespace T4_删除有序数组中的重复项2
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int fast = 1, slow = 1;
            int n = nums.Length;
            //int index = 0;
            if (nums.Length == 0)
            {
                return 0;
            }
            int index = 0;
            while (fast < n)
            {
                if (nums[fast] != nums[fast - 1])
                {
                    if (nums[fast] == nums[fast + 1] && index == 0)
                    {
                        nums[slow++] = nums[fast];
                        index = 1;
                    }
                    else
                    {
                        index = 0;
                    }

                    //for (int i = slow; i < fast; i++)
                    //{
                    //    if ((nums[slow] == nums[slow + 1] && index == 0) || (nums[slow] != nums[slow + 1] && index == 1))
                    //    {
                    //        slow++;
                    //        index++;
                    //    }
                    //    else
                    //    {
                    //        nums[slow++] = nums[fast];
                    //        index = 0;
                    //    }
                    //}
                    nums[slow++] = nums[fast];//增加几个数字
                }
                fast++;
            }
            for (int i = slow; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
            return slow;
        }

        public int Ans(int[] nums)
        {
            int fast = 2, slow = 2;
            int n = nums.Length;
            if (n <= 2)
            {
                return n;
            }
            while (fast < n)
            {
                // if (nums[fast] != nums[fast - 1])
                // {
                if (nums[slow - 2] != nums[fast])
                {
                    nums[slow++] = nums[fast];
                }
                // }
                fast++;
            }
            return slow;
        }

        /// <summary>
        /// 有序数组删除重复项通解
        /// </summary>
        /// <param name="nums">传入数组</param>
        /// <param name="num">重复个数</param>
        /// <returns></returns>
        public int MyTest(int[] nums, int num)//
        {
            //int num = 3;
            int fast = num, slow = num;
            int n = nums.Length;

            if (n <= num)
            {
                return n;
            }
            while (fast < n)
            {
                if (nums[slow - num] != nums[fast])
                {
                    nums[slow++] = nums[fast];
                }
                fast++;
            }
            for (int i = slow; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
            return slow;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new();

            int[] nums = [0, 0, 1, 1, 1, 1, 2, 3, 3];
            int k = solution.RemoveDuplicates(nums);
            Console.WriteLine(k);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
