namespace T16_分发糖果
{
    public class Solution
    {
        public void Show(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0} ", nums[i]);
            }
            Console.WriteLine();
        }
        public int Ans(int[] ratings)//递增时加上前一个数的值，递减时记录递减数列长度
        {
            int n = ratings.Length;
            int candyNumber = 1;
            int dec = 0;
            int inc = 1;
            int pre = 1;
            for (int i = 1; i < n; i++)
            {
                if (ratings[i] >= ratings[i - 1])
                {
                    dec = 0;
                    if (ratings[i] == ratings[i - 1])
                    {
                        pre = 1;
                    }
                    else
                    {
                        pre = pre + 1;
                    }
                    candyNumber += pre;
                    inc = pre;
                }
                else
                {
                    dec++;
                    if (dec == inc)
                    {
                        dec++;
                    }
                    candyNumber += dec;
                    pre = 1;
                }
            }
            return candyNumber;
        }
        public int Candy(int[] ratings)
        {
            int candy = 0;
            int n = ratings.Length;
            int index = 0;
            int[] larr = new int[n];
            larr[0] = 0;
            int[] rarr = new int[n];
            rarr[n - 1] = 0;
            for (int i = 1; i < n; i++)
            {
                if (ratings[i - 1] < ratings[i])//上坡
                {
                    larr[i] = larr[i - 1] + 1;
                }
                if (ratings[n - i] < ratings[n - i - 1])//反向上坡
                {
                    rarr[n - i - 1] = rarr[n - i] + 1;
                }
            }
            Show(larr);
            Show(rarr);
            for (int i = 0; i < n; i++)
            {
                candy = candy + 1 + (larr[i] > rarr[i] ? larr[i] : rarr[i]);
            }
            Console.WriteLine(candy);
            return candy;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new();
            s.Candy([1, 0, 2]);
        }
    }
}
