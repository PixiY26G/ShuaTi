using System.Collections.Generic;

namespace hot_49_字母异位词分组
{
    //给你一个字符串数组，请你将 字母异位词 组合在一起。可以按任意顺序返回结果列表。
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strs = ["eat", "tea", "tan", "ate", "nat", "bat"];

            Solution s = new();
            s.GroupAnagrams(strs);
            strs = [""];
            strs = ["a"];
        }
    }
    public class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> dic = new();
            for (int i = 0; i < strs.Length; i++)
            {
                //Array里有对char排序的方法
                char[] c = strs[i].ToCharArray();
                Array.Sort(c);
                string key = new string(c);
                //如果字典中存在该排序，则在该键值对值下加入新值
                if (dic.ContainsKey(key))
                {
                    dic[key].Add(strs[i]);
                }
                //没找到则添加新键值对
                else
                {
                    dic.Add(key, new List<string>());
                    dic[key].Add(strs[i]);
                }
            }
            //返回
            return new List<IList<string>>(dic.Values);
        }
    }
}
