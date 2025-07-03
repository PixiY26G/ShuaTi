namespace T1_合并两个有序数组
{
    #region 题干
    /// <summary>
    /// 给你两个按 非递减顺序 排列的整数数组 nums1 和 nums2，另有两个整数 m 和 n ，分别表示 nums1 和 nums2 中的元素数目。

    //    请你 合并 nums2 到 nums1 中，使合并后的数组同样按 非递减顺序 排列。

    //注意：最终，合并后数组不应由函数返回，而是存储在数组 nums1 中。为了应对这种情况，nums1 的初始长度为 m + n，其中前 m 个元素表示应合并的元素，后 n 个元素为 0 ，应忽略。nums2 的长度为 n 。
    //示例 1：
    //输入：nums1 = [1, 2, 3, 0, 0, 0], m = 3, nums2 = [2, 5, 6], n = 3
    //输出：[1, 2, 2, 3, 5, 6]
    //解释：需要合并[1, 2, 3] 和[2, 5, 6] 。
    //合并结果是[1, 2, 2, 3, 5, 6] ，其中斜体加粗标注的为 nums1 中的元素。
    //示例 2：

    //输入：nums1 = [1], m = 1, nums2 = [], n = 0
    //输出：[1]
    //解释：需要合并[1] 和[] 。
    //合并结果是[1] 。
    //示例 3：

    //输入：nums1 = [0], m = 0, nums2 = [1], n = 1
    //输出：[1]
    //解释：需要合并的数组是[] 和[1] 。
    //合并结果是[1] 。
    //注意，因为 m = 0 ，所以 nums1 中没有元素。nums1 中仅存的 0 仅仅是为了确保合并结果可以顺利存放到 nums1 中。


    //提示：

    //nums1.length == m + n
    //nums2.length == n
    //0 <= m, n <= 200
    //1 <= m + n <= 200
    //-109 <= nums1[i], nums2[j] <= 109

    //进阶：你可以设计实现一个时间复杂度为 O(m + n) 的算法解决此问题吗？
    /// </summary>
    #endregion
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = m; i < m + n; i++)
            {
                nums1[i] = nums2[i - m];
            }

            Array.Sort(nums1);
            // 直接使用内置的排序函数
            // 但是时间复杂度是 O(nlogn)

        }
        //观察可知，nums 
        //  的后半部分是空的，可以直接覆盖而不会影响结果。因此可以指针设置为从后向前遍历，每次取两者之中的较大者放进 nums 
        //  的最后面。

        public void NewMerge(int[] nums1, int m, int[] nums2, int n)
        {
            // 从后往前遍历，使用三个指针
            int p1 = m - 1; // 指向 nums1 有效元素的最后一个位置
            int p2 = n - 1; // 指向 nums2 的最后一个位置

            // 从合并后数组的最后一个位置开始填充元素
            for (int p = m + n - 1; p >= 0; p--)
            {
                if (p1 < 0)
                {
                    // 如果 nums1 已经遍历完，直接将 nums2 剩余元素放入 nums1
                    nums1[p] = nums2[p2];
                    p2--;
                }
                else if (p2 < 0)
                {
                    // 如果 nums2 已经遍历完，nums1 剩余元素无需处理，因为它们已经在正确位置
                    break;
                }
                else if (nums1[p1] >= nums2[p2])
                {
                    // nums1 当前元素较大，放入合并位置
                    nums1[p] = nums1[p1];
                    p1--;
                }
                else
                {
                    // nums2 当前元素较大，放入合并位置
                    nums1[p] = nums2[p2];
                    p2--;
                }
            }
        }
        //public void SMerge(int[] nums1, int m, int[] nums2, int n)
        //{
        //    int
        //}
    }
    internal class Program
    {
        //标准答案
        static public void Ans(int[] nums1, int m, int[] nums2, int n)
        {
            int p1 = m - 1;
            int p2 = n - 1;
            int p = m + n - 1;
            int cur;
            //while (p1 > 0 && p2 > 0)
            //{
            //    nums1[p--] = nums1[p1] > nums2[p2] ? nums1[p1--] : nums2[p2--];

            //}
            //while (p1 < 0 && p2 > 0)
            //{
            //    nums1[p--] = nums2[p2--];

            //}


            while (p1 >= 0 || p2 >= 0)
            {
                if (p1 == -1)
                {
                    cur = nums2[p2--];
                }
                else if (p2 == -1)
                {
                    cur = nums1[p1--];
                }
                else if (nums1[p1] > nums2[p2])
                {
                    cur = nums1[p1--];
                }
                else
                {
                    cur = nums2[p2--];
                }
                nums1[p--] = cur;
            }
        }
        static void Main(string[] args)
        {
            int[] ints1 = { 1, 2, 3, 0, 0, 0 };
            int[] ints2 = { 2, 5, 6 };
            int m = 3;
            int n = 3;
            Solution solution = new Solution();
            //solution.Merge(ints1, m, ints2, n);
            //solution.NewMerge(ints1, m, ints2, n);
            Ans(ints1, m, ints2, n);
            Console.WriteLine(string.Join(",", ints1));

        }
    }
}
