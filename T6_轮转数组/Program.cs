namespace T6_轮转数组
{
    //将数组向有转，写三种方法
    public class Solution
    {

        public void Rotate1(int[] nums, int k)
        {
            int n = nums.Length;
            int[] ansNums = new int[n];
            for (int i = 0; i < n; i++)
            {
                ansNums[(i + k) % n] = nums[i];
            }
            Array.Copy(ansNums, nums, n);
        }
        public void Rotate2(int[] nums, int k)
        {
            int[] copyArray = new int[nums.Length];
            Array.Copy(nums, copyArray, nums.Length);
            for (int i = 0; i + k < nums.Length; i++)
            {
                nums[i + k] = copyArray[i];
            }
            for (int i = 0; i < k; i++)
            {
                nums[i] = copyArray[nums.Length - k + i];
            }
        }
        public void Show(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{nums[i]} ");
            }
            Console.WriteLine();
        }
        public void Rotate3(int[] nums, int k)
        {
            int length = nums.Length;
            k = k % length;
            if (k == 0)
            {
                return;
            }
            int tmp = 0;
            //向右移动,先反转全部;向左移动,最后反转全部
            Array.Reverse(nums);
            Show(nums);
            Array.Reverse(nums, 0, k);
            Show(nums);
            Array.Reverse(nums, k, length - k);
            Show(nums);
            //    Reverse(nums, 0, length);
            //    Reverse(nums, 0, k);
            //    Reverse(nums, k, length - k);
            //}
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Solution solution = new();
                solution.Rotate3([1, 2, 3, 4, 5, 6, 7], 3);
            }
        }
    }
}