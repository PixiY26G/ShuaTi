using System.Text;

namespace T21_最长公共前缀
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return "";

            }
            //string ret = "";
            string str = strs[0];
            //int n = str.Length;
            //由于前缀长度永远小于任意字符串长度长度
            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(str) != 0)
                {
                    //str.Remove(str.Length - 1);
                    //continue;
                    str = str.Remove(str.Length - 1);
                    // 如果 str 为空，说明没有公共前缀，直接返回
                    if (str.Length == 0)
                    {
                        return "";
                    }
                }
            }
            Console.WriteLine(str);
            return str;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strs = ["flower", "flow", "flight"];
            Solution s = new Solution();
            s.LongestCommonPrefix(strs);
        }
    }
}
