namespace hot_数组_合并区间
{
    //以数组 intervals 表示若干个区间的集合，其中单个区间为 intervals[i] = [starti, endi] 。
    //请你合并所有重叠的区间，并返回 一个不重叠的区间数组，该数组需恰好覆盖输入中的所有区间 。
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        //public class Item
        //{
        //    public int start;
        //    public int end;
        //    public Item(int start, int end)
        //    {
        //        this.start = start;
        //        this.end = end;
        //    }
        //}
        public class Solution
        {
            public int[][] Merge(int[][] intervals)
            {
                //让intervals按照start大小从小到大排列
                //Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));
                Array.Sort(intervals, (x, y) =>
                {
                    return x[0].CompareTo(y[0]);
                });
                List<int[]> merged = new();
                for (int i = 0; i < intervals.Length; i++)
                {
                    int L = intervals[i][0], R = intervals[i][1];
                    if (merged.Count() == 0 || merged[merged.Count - 1][1] < L)//如果merged里面没有内容或者merged的end小于前一个
                                                                               //判断最后一个数组的R是否包括了L
                                                                               //即新数组和旧数组间有无重复部分
                    {
                        merged.Add(new int[] { L, R });
                    }
                    else//
                    {
                        merged[merged.Count - 1][1] = Math.Max(merged[merged.Count - 1][1], R);
                    }
                }
                return merged.ToArray();
            }
        }
    }
}
