namespace T13_除自身以外是数组的乘积
{
    public class Solution
    {
        public int[] ProductExceptSelf1(int[] nums)
        {
            int[] answer = new int[nums.Length];
            //List<int> arr = new List<int>(nums);\
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                answer[i] = 1;
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    answer[i] *= nums[j];
                }
            }
            Show(answer);
            return answer;
        }
        public void Show(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0}  ", nums[i]);
            }
            Console.WriteLine();
        }
        public int[] ProductExceptSelf2(int[] nums)
        {
            int n = nums.Length;
            int[] ans = new int[n];
            int[] r = new int[n];
            int[] l = new int[n];
            l[0] = 1;
            r[n - 1] = 1;
            for (int i = 1; i < n; i++)
            {
                l[i] = nums[i - 1] * l[i - 1];
            }
            for (int i = n - 2; i >= 0; i--)
            {
                r[i] = r[i + 1] * nums[i + 1];
            }
            for (int i = 0; i < n; i++)
            {
                ans[i] = l[i] * r[i];
            }
            Show(ans);
            return ans;
        }
        public int[] Ans(int[] nums)
        {
            int[] result = new int[nums.Length];
            result[0] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                result[i] = result[i - 1] * nums[i - 1];
            }

            int right = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                result[i] *= right;
                right *= nums[i];
            }
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new();
            int[] ints = s.ProductExceptSelf2([1, 2, 3, 4]);

        }
    }
}
