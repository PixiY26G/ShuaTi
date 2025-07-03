namespace T3_删除有序数组中的重复项
{
    //删除有序数组中的所有重复项
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int index = nums[0];
            int k = 1;
            //第一位是不变的
            for (int left = 1; left < nums.Length; left++)
            {
                if (nums[left] != index)
                {
                    index = nums[left];
                    nums[k] = nums[left];
                    k++;
                }
            }
            for (int i = k; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
            return k;
        }
        public int Ans(int[] nums)
        {
            int fast = 1, slow = 1;
            int n = nums.Length;
            if (nums.Length == 0)
            {
                return 0;
            }
            while (fast < n)
            {
                if (nums[fast] != nums[fast - 1])
                {
                    nums[slow++] = nums[fast];
                }
                fast++;
            }
            return slow;
        }
        public int MyTest(int[] nums)
        {
            int num = 3;
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

            int[] nums = [1, 1, 1, 2, 2, 3];
            int k = solution.MyTest(nums);
            Console.WriteLine(k);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
