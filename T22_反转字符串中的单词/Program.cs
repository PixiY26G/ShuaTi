using System.Text;

namespace T22_反转字符串中的单词
{
    public class Solution
    {
        public string ReverseWords(string s)
        {
            int n = s.Length;
            StringBuilder str = new StringBuilder();
            int fast = n - 1;
            int slow = n - 1;
            while (slow >= 0)
            {
                slow = fast;
                while (slow >= 0 && s[slow] == ' ')
                {
                    slow--;
                }
                fast = slow;
                while (fast >= 0 && s[fast] != ' ')
                {
                    fast--;
                }
                //fast++;
                if (fast < slow)
                {
                    if (str.Length > 0)
                    {
                        str.Append(' ');
                    }
                    for (int i = fast + 1; i <= slow; i++)
                    {
                        str.Append(s[i]);
                    }
                }
            }

            Console.WriteLine(str);

            return str.ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "a";
            Solution so = new Solution();
            string processed = so.ReverseWords(s);
            //Console.WriteLine(processed);
        }
    }
}
