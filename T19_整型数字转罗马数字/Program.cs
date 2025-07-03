using System.Globalization;
using System.Text;

namespace T19_整型数字转罗马数字
{
    public class Solution
    {
        public string IntToRoman(int num)
        {
            //string ret = "";
            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] strs = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            StringBuilder ret = new StringBuilder();
            for (int i = 0; i < values.Length; i++)
            {
                while (num >= values[i])
                {
                    ret.Append(strs[i]);
                    num -= values[i];
                }
            }
            Console.WriteLine(ret);
            return ret.ToString();
        }
        public string Ans(int num)
        {
            string result = "";
            while (num >= 1000)
            {
                num -= 1000;
                result += "M";
            }
            if (num >= 900)
            {
                num -= 900;
                result += "CM";
            }
            if (num >= 500)
            {
                num -= 500;
                result += "D";
            }
            if (num >= 400)
            {
                num -= 400;
                result += "CD";
            }
            while (num >= 100)
            {
                num -= 100;
                result += "C";
            }
            if (num >= 90)
            {
                num -= 90;
                result += "XC";
            }
            if (num >= 50)
            {
                num -= 50;
                result += "L";
            }
            if (num >= 40)
            {
                num -= 40;
                result += "XL";
            }
            while (num >= 10)
            {
                num -= 10;
                result += "X";
            }
            if (num >= 9)
            {
                num -= 9;
                result += "IX";
            }
            if (num >= 5)
            {
                num -= 5;
                result += "V";
            }
            if (num >= 4)
            {
                num -= 4;
                result += "IV";
            }
            while (num > 0)
            {
                num -= 1;
                result += "I";
            }
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new();
            s.IntToRoman(3000);
        }
    }
}
