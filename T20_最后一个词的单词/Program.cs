namespace T20_最后一个词的单词
{
    public class Solution
    {
        public int LengthOfLastWord(string s)
        {
            int ret = 0;
            int n = s.Length;
            bool b = false;
            for (int i = 0; i < n; i++)
            {
                if (s[n - i - 1] != ' ')
                {
                    b = true;
                }


                if (s[n - i - 1] == ' ' && b)
                {
                    return ret;
                }

                else if (s[n - i - 1] != ' ' && b)
                {
                    ret++;
                }
            }
            return ret;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Solution solution = new Solution();
            i = solution.LengthOfLastWord("a ");
            Console.WriteLine(i);
        }
    }
}
