namespace hot_子串_最小覆盖子串
{
    //    给定两个字符串 s 和 t，长度分别是 m 和 n，返回 s 中的 最短窗口 子串，
    //    使得该子串包含 t 中的每一个字符（包括重复字符）。如果没有这样的子串，返回空字符串 ""。

    //测试用例保证答案唯一。
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class Solution
    {

        public string MinWindow(string s, string t)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t) || s.Length < t.Length)
                return "";

            // 统计 t 中字符出现次数
            Dictionary<char, int> targetCount = new Dictionary<char, int>();
            foreach (char c in t)
            {
                targetCount[c] = targetCount.ContainsKey(c) ? targetCount[c] + 1 : 1;
            }

            // 滑动窗口统计
            Dictionary<char, int> windowCount = new Dictionary<char, int>();

            int left = 0, right = 0;
            int required = targetCount.Count; // 需要满足的字符种类数
            int formed = 0; // 当前窗口中已满足的字符种类数

            int minLength = int.MaxValue;
            int minLeft = 0, minRight = 0;

            while (right < s.Length)
            {
                char c = s[right];

                // 更新窗口统计
                windowCount[c] = windowCount.ContainsKey(c) ? windowCount[c] + 1 : 1;

                // 检查当前字符是否满足条件
                if (targetCount.ContainsKey(c) && windowCount[c] == targetCount[c])
                {
                    formed++;
                }

                // 当窗口满足条件时，尝试收缩左边界
                while (left <= right && formed == required)
                {
                    c = s[left];

                    // 更新最小窗口
                    int currentLength = right - left + 1;
                    if (currentLength < minLength)
                    {
                        minLength = currentLength;
                        minLeft = left;
                        minRight = right;
                    }

                    // 移除左边界字符
                    windowCount[c]--;
                    if (targetCount.ContainsKey(c) && windowCount[c] < targetCount[c])
                    {
                        formed--;
                    }
                    left++;
                }

                right++;
            }

            return minLength == int.MaxValue ? "" : s.Substring(minLeft, minRight - minLeft + 1);
        }
    }

}
