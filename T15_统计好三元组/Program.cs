namespace T15_统计好三元组
{
    public class Solution
    {
        public int CountGoodTriplets(int[] arr, int a, int b, int c)
        {
            int n = arr.Length;
            if (n < 3)
            {
                return 0;
            }
            int ret = 0;
            for (int i = 0; i < n - 2; i++)
            {
                for (int j = i + 1; j < n - 1; j++)
                {
                    if (Math.Abs(arr[i] - arr[j]) <= a)
                    {
                        for (int k = j + 1; k < n; k++)
                        {
                            if (Math.Abs(arr[j] - arr[k]) <= b && Math.Abs(arr[i] - arr[k]) <= c)
                            {
                                ret++;
                            }
                        }
                    }
                }
            }
            return ret;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new();
            int[] arr = [3, 0, 1, 1, 9, 7];
            int a = 7;
            int b = 2;
            int c = 3;
            Console.WriteLine(s.CountGoodTriplets(arr, a, b, c));
        }
    }
}
