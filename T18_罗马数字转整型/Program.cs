namespace T18_罗马数字转整型
{
    enum E_LuoMa
    {
        I, V, X, L, C, D, M
    }
    public class Solution
    {
        public int RomanToInt(string s)
        {
            int sn = s.Length;
            int[] arr = new int[sn];
            int ret = 0;
            //给arr赋值
            for (int i = 0; i < sn; i++)
            {
                switch (s[i])
                {
                    case 'I':
                        arr[i] = 1;
                        break;
                    case 'V':
                        arr[i] = 5;
                        break;
                    case 'X':
                        arr[i] = 10;
                        break;
                    case 'L':
                        arr[i] = 50;
                        break;
                    case 'C':
                        arr[i] = 100;
                        break;
                    case 'D':
                        arr[i] = 500;
                        break;
                    case 'M':
                        arr[i] = 1000;
                        break;
                    default:
                        return 0;
                        break;
                }
            }
            //判断正负号,且赋值
            for (int i = 0; i < sn; i++)
            {
                if (i < sn - 1)
                {
                    if (arr[i] < arr[i + 1])
                    {
                        arr[i] = -arr[i];
                    }
                }

                ret += arr[i];
            }
            Console.WriteLine(ret);
            return ret;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new();
            s.RomanToInt("III");
            s.RomanToInt("IV");
            s.RomanToInt("LVIII");
        }
    }
}
