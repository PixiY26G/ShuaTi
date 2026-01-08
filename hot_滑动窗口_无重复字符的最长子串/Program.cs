namespace hot_滑动窗口_无重复字符的最长子串
{
    //给定一个字符串 s ，请你找出其中不含有重复字符的 最长 子串 的长度。
    //什么是滑动窗口？
    //其实就是一个队列,比如例题中的 abcabcbb，进入这个队列（窗口）为 abc 满足题目要求，当再进入 a，队列变成了 abca，这时候不满足要求。所以，我们要移动这个队列！

    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "bbbbb";
            //string s1 = "au";
            Solution so = new();
            //Console.WriteLine(so.LengthOfLongestSubstring(s1));
            Console.WriteLine(so.Ans2LengthOfLongestSubstring(s));
        }
    }

    public class Solution
    {
        //public int LengthOfLongestSubstring(string s)
        //{
        //    int n = s.Length;
        //    Dictionary<char, bool> dic = new();
        //    //当s的长度小于1时
        //    if (s == null)
        //    {
        //        return 0;
        //    }
        //    if (s.Length == 1 || n == 0)
        //    {
        //        return n;
        //    }

        //    //int left = 0;
        //    //int right = 0;
        //    int max = 1;
        //    for (int i = 0; i < n; i++)
        //    {
        //        dic.Add(s[i], false);
        //        int right = i + 1;
        //        while (right < n && !dic.ContainsKey(s[right]))
        //        {

        //            dic.Add(s[right], false);
        //            right++;

        //            max = Math.Max(max, dic.Count);

        //        }
        //        //if (right < n && dic.ContainsKey(s[right]))
        //        //{
        //        //    max = Math.Max(max, dic.Count);

        //        //}
        //        dic.Clear();
        //    }
        //    return max;
        //}
        public int AnsLengthOfLongestSubstring(string s)
        {
            int count = 0;
            int index = 0;
            var Dict = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                //维护一个滑动窗口
                if (Dict.ContainsKey(s[i]))
                {
                    index = Math.Max(Dict[s[i]], index);
                    Console.WriteLine("index = " + index);
                }
                Dict[s[i]] = i;
                //Dict.Add(s[i], i);
                //这里必须用索引器而不能用add，因为如果键已经存在，需要更新到最新位置
                //Console.WriteLine(Dict[s[i]]);


                count = Math.Max(count, i - index);
                Console.WriteLine($"count({count}) =Max(count({count}) , ((i({i}) - index({index}) + 1 )={i - index + 1})");


                Console.Write("count: " + count + $" s[{i}]:{s[i]}");
                foreach (var key in Dict.Keys)
                {
                    Console.Write($" key:{key} value:{Dict[key]} ");
                }
                Console.WriteLine();
            }
            return count;
        }
        public int Ans2LengthOfLongestSubstring(string s)
        {
            HashSet<char> set = new();
            int left = 0;
            int right = 0;
            int ans = 0;
            while (right < s.Length)
            {
                //维护一个滑动窗口
                if (!set.Contains(s[right]))//当找不到重复时往窗口内加值
                {
                    set.Add(s[right]);
                    right++;
                }
                else//找到时减值
                {
                    set.Remove(s[left]);
                    left++;
                }
                ans = Math.Max(ans, right - left);//效率更高
                //if (ans < (right - left))
                //{
                //    ans = right - left;
                //}
            }
            return ans;
        }
    }
}
