namespace hot_矩阵_搜索二维矩阵
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] martix = [[-1, 3]];
            Solution s = new();
            s.SearchMatrix(martix, 1);
        }
    }
    public class Solution
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            bool ret = false;
            if (target < matrix[0][0] || target > matrix[m - 1][n - 1])
            {
                return false;
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] == target)
                    {
                        return true;
                    }
                }
            }
            return ret;
        }
    }
}
