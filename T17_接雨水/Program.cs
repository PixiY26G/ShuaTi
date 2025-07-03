namespace T17_接雨水
{
    public class Solution
    {
        public int Trap(int[] height)
        {
            if (height.Length <= 2)
            {
                return 0;
            }
            int n = height.Length;
            int left = 0;
            int right = n - 1;
            int h = 1;
            int m = 0;
            int wall = 0;
            for (int i = 0; i < n; i++)
            {
                wall += height[i];
            }
            while (left <= right)
            {
                while (left <= right && height[left] < h)
                {
                    left++;
                }
                while (left <= right && height[right] < h)
                {
                    right--;
                }


                if (left <= right)
                {
                    m = m + right - left + 1;
                    h++;
                }
                //if (left == right)
                //{
                //    break;
                //}
            }
            Console.WriteLine(m - wall);
            return m - wall;
        }

        public int Ans(int[] height)
        {
            //int left = 0;
            int ans = 0;
            Stack<int> stk = new Stack<int>();
            for (int i = 0; i < height.Length; i++)
            {
                while (stk.Count > 0 && height[i] > height[stk.Peek()])
                {
                    int top = stk.Pop();
                    if (stk.Count == 0)
                    {
                        break;
                    }
                    int left = stk.Peek();
                    int currWidth = i - left - 1;
                    int currHeight = Math.Min(height[left], height[i]) - height[top];
                    ans += currWidth * currHeight;
                }
                stk.Push(i);
            }
            return ans;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new();
            s.Trap([0, 2, 0]);
        }
    }
}
