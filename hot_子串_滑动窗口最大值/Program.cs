namespace hot_子串_滑动窗口最大值
{
    //    给你一个整数数组 nums，有一个大小为 k 的滑动窗口从数组的最左侧移动到数组的最右侧。你只可以看到在滑动窗口内的 k 个数字。滑动窗口每次只向右移动一位。

    //返回 滑动窗口中的最大值 。
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [1, 3, -1, -3, 5, 3, 6, 7];
            int k = 3;
            Solution s = new();
            int[] ans = s.MaxSlidingWindow(nums, k);
            for (int i = 0; i < ans.Length; i++)
            {
                Console.Write(ans[i] + " ");
            }
        }
    }
    public class Solution
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            #region 超时
            //for (int left = 0; left < ansLen; left++)//left为滑动窗口左
            //{
            //    Queue<int> ints = new Queue<int>();//用于记录滑动窗口的队列
            //    int right = left + k;//right为滑动 窗口右
            //    int max = nums[left];
            //    for (int i = 0; i < k; i++)//得到滑动窗口
            //    {
            //        max = Math.Max(max, nums[i + left]);
            //    }
            //    Console.WriteLine(" max = " + max);
            //    ans[left] = max;
            //}
            #endregion
            int nLen = nums.Length;
            if (nLen == 0 || k > nLen)
            {
                return [];
            }
            int ansLen = nLen - k + 1;
            int[] ans = new int[ansLen];

            LinkedList<int> deque = new LinkedList<int>();//储存索引
            for (int i = 0; i < nLen; i++)
            {
                //移除超过范围的元素 维护一个窗口
                //例： deque.First.Value > i - k时，i=4,k=3,first.value = 1,移除
                if (deque.Count > 0 && deque.First.Value <= i - k)
                {
                    deque.RemoveFirst();
                }

                //从队尾移除当前元素的元素索引
                while (deque.Count > 0 && nums[deque.Last.Value] < nums[i])
                {
                    deque.RemoveLast();
                }
                //加入当前元素
                deque.AddLast(i);
                //返回最大值
                if (i >= k - 1)
                {
                    ans[i - k + 1] = nums[deque.First.Value];
                }
            }
            return ans;
        }
    }
}
