namespace T11_H指数
{
    public class Solution
    {
        public int HIndex(int[] citations)
        {
            int n = citations.Length;
            Array.Sort(citations);
            Array.Reverse(citations);
            int hIndex = 0;
            for (int i = 0; i < n; i++)
            {
                if (citations[i] >= citations.Length)
                {
                    hIndex++;
                }
                else if (citations[i] > hIndex && citations[i] < citations.Length)
                {
                    hIndex++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(hIndex);
            return hIndex;
        }

        public int Ans(int[] citations)
        {
            int h = citations.Length;
            int[] arr = new int[h + 1];
            foreach (int val in citations)
            {
                if (val < h)
                {
                    arr[val]++;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                while (arr[i] > 0)
                {
                    if (i >= h)
                    {
                        break;
                    }
                    arr[i]--;
                    h--;
                }
            }
            return h;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new();
            solution.HIndex([3, 0, 6, 1, 5]);
        }
    }
}
