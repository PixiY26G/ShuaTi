namespace T10_跳跃游戏2
{
    public class Solution
    {
        public int Ans(int[] nums)
        {
            int len = nums.Length;
            int end = 0;
            int maxPosition = 0;
            int steps = 0;

            for (int i = 0; i < len - 1; i++)
            {
                maxPosition = Math.Max(maxPosition, i + nums[i]);
                if (i == end)
                {
                    end = maxPosition;//en
                    steps++;
                }
            }
            return steps;
        }
        public int CanJump(int[] nums)
        {
            int steps = 0;
            int position = nums.Length - 1;
            //从尾到头找，positoin小于0的时候，就找全了
            while (position > 0)
            {
                //从左到右遍历，第一个能到position的就是跳跃最长的
                for (int i = 0; i < position; i++)
                {
                    if (i + nums[i] >= position)
                    {
                        //找到后，跳出当前循环
                        position = i;
                        steps++;
                        break;
                    }
                }
            }
            return steps;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new();
            int i1 = solution.CanJump([2, 3, 1, 1, 4]);
            Console.WriteLine(i1);
            int i2 = solution.CanJump([2, 1]);
            Console.WriteLine(i2);
            //int i3 = solution.CanJump([0]);
            //Console.WriteLine(i3);
        }
    }
}
