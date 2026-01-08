namespace hot_双指针_移动零
{
    //    给定一个数组 nums，编写一个函数将所有 0 移动到数组的末尾，同时保持非零元素的相对顺序。

    //请注意 ，必须在不复制数组的情况下原地对数组进行操作。
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [0, 1, 0, 3, 12];
            Solution s = new();
            s.MoveZeroes(nums);
            foreach (var num in nums)
            {
                Console.Write(num + "  ");
            }
        }
    }
    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            int[] ans = new int[nums.Length];
            int left = 0;
            int right = nums.Length - 1;
            int index = 0;
            while (left <= right)
            {
                while (left <= right && nums[left] != 0)
                {
                    //当数组内不为零时
                    ans[index++] = nums[left++];
                    //left++;
                    //index++;
                }
                while (left <= right && nums[left] == 0)
                {
                    left++;
                }
            }
            Array.Copy(ans, nums, nums.Length);
            Console.WriteLine(nums);
        }
    }
}
