namespace T5_多数元素
{
    //获得数组中超过半数的元素多数元素
    public class Solution
    {
        public int MajorityElement(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }

            Dictionary<int, int> dic = new();
            int flag = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]] += 1;
                }
                else
                {
                    dic.Add(nums[i], 1);
                }
            }
            KeyValuePair<int, int> index = new KeyValuePair<int, int>(nums[0], dic[nums[0]]);
            foreach (KeyValuePair<int, int> item in dic)
            {
                if (index.Value < item.Value)
                {
                    index = item;
                }
            }
            return index.Key;
        }
        public int Ans(int[] nums)
        {
            int rtn = nums[0];//开始
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    rtn = nums[i];
                    count++;
                    continue;
                }
                if (nums[i] == rtn)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
            return rtn;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = [3, 2, 3];
            Solution solution = new Solution();
            int i = solution.MajorityElement(ints);
            Console.WriteLine(i);
        }
    }
}
