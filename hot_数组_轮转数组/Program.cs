namespace hot_数组_轮转数组
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public class Solution
        {
            public void Rotate(int[] nums, int k)
            {
                int nLen = nums.Length;
                int[] ans = new int[nLen];
                for (int i = 0; i < nLen; i++)
                {
                    ans[(i + k) % nLen] = nums[i];
                    Console.WriteLine(ans[(i + k) % nLen]);
                }
                Array.Copy(ans, nums, nLen);
            }
        }
    }
}
