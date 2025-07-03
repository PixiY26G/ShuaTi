using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace T23__Z_字形变换
{
    public class Solution
    {
        public string Convert(string s, int numRows)
        {
            int n = s.Length, r = numRows;
            if (r == 1 || r >= n)
            {
                return s;
            }
            int t = numRows * 2 - 2;
            int c = (n + t - 1) / t * (r - 1);
            char[][] mat = new char[r][];
            for (int i = 0; i < r; i++)
            {
                mat[i] = new char[c];
            }
            for (int i = 0, x = 0, y = 0; i < n; i++)
            {
                mat[x][y] = s[i];
                if (i % t < r - 1)
                {
                    ++x;
                }
                else
                {
                    --x;
                    ++y;
                }
            }
            StringBuilder ret = new StringBuilder();
            foreach (char[] row in mat)
            {
                foreach (char item in row)
                {
                    if (item != 0)
                    {
                        ret.Append(item);
                    }
                }
            }

            return ret.ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution so = new Solution();
            string s;
            int numRows;
            s = "PAYPALISHIRING";
            numRows = 3;
            string conver = so.Convert(s, numRows);
        }
    }
}
