namespace T7_买卖股票的最佳时机
{
    public class Solution
    {
        public int TimeOutMaxProfit(int[] prices)//超时
        {
            int buy = 0;
            int sell = 0;
            int max = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                buy = prices[i];
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (buy < prices[j])
                    {
                        sell = prices[j];
                        if (sell - buy > max)
                        {
                            max = sell - buy;
                        }
                    }
                }

            }
            return max;
        }
        public int MaxProfit(int[] prices)
        {
            int ans = 0;
            int min_price = prices[0];
            foreach (int p in prices)
            {
                ans = ans > p - min_price ? ans : p - min_price;
                min_price = min_price < p ? min_price : p;
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
