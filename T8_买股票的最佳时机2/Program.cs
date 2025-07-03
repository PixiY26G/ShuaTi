namespace T8_买股票的最佳时机2
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int ans = 0;

            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i + 1] > prices[i])
                {
                    ans += (prices[i + 1] - prices[i]);
                }
            }
            return ans;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int ans1 = s.MaxProfit([1, 2]);
            int ans2 = s.MaxProfit([7, 1, 5, 3, 6, 4]);
            int ans3 = s.MaxProfit([7, 6, 4, 3, 1]);
            Console.WriteLine(ans1);
            Console.WriteLine(ans2);
            Console.WriteLine(ans3);
        }
    }
}
