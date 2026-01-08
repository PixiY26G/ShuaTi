namespace hot_滑动窗口_找到字符串中所有字母异位词
{
    //给定两个字符串 s 和 p，找到 s 中所有 p 的 异位词 的子串，返回这些子串的起始索引。不考虑答案输出的顺序。
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "cbaebabacd", p = "abc";
            Solution1 ss = new();
            ss.FindAnagrams(s, p);
        }
    }
    public class Solution
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            List<int> ans = new();
            int n = s.Length;
            int m = p.Length;
            if (n < m)//当子字符串比父长时
            {
                return ans;
            }
            //HashSet<char> set = new();

            int left = 0;
            int right = m - 1;
            while (right < n)
            {
                string str = s.Substring(left, m);
                if (Pan(str, p))
                {
                    ans.Add(left);
                }
                //if (!Pan(chars.ToString(), p))
                //{

                //}
                left++;
                right++;
            }
            return ans;
        }
        public bool Pan(string a, string b)//判断是否为异位词，默认a,b等长
        {
            int[] ints = new int[26];

            for (int i = 0; i < a.Length; i++)
            {
                ints[(int)(a[i] - 'a')]++;
                ints[(int)(b[i] - 'a')]--;
            }

            for (int i = 0; i < 26; i++)
            {
                if (ints[i] != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
    public class Solution1
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            if (s.Length < p.Length)
            {
                return [];
            }

            List<int> result = [];
            int[] count = new int[26];
            //在count中记录p
            foreach (char c in p)
            {
                count[c - 'a']++;
            }

            int left = 0;
            int right = 0;

            while (right < s.Length)
            {
                if (count[s[right] - 'a'] > 0)//当count大于0，也就是p中存在该字母
                {
                    count[s[right] - 'a']--;//减少一个
                    right++;//向右一位
                    if (right - left == p.Length)//
                    {
                        result.Add(left);
                        Console.WriteLine(s[left]);
                    }
                }
                else//不存在
                {
                    count[s[left] - 'a']++;
                    left++;
                }
            }

            return result;
        }

    }
}
