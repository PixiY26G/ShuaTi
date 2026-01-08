namespace hot_矩阵_矩阵置零
{
    //给定一个 m x n 的矩阵，如果一个元素为 0 ，则将其所在行和列的所有元素都设为 0 。请使用 原地 算法。
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = [[0, 1, 2, 0], [3, 4, 5, 2], [1, 3, 1, 5]];
            Solution s = new();
            s.SetZeroes(matrix);

            s.Show(matrix);
        }
    }
    public class Solution
    {
        public void SetZeroes(int[][] matrix)
        {
            int m = matrix.Length;//行数
            int n = matrix[0].Length;//列数
            bool[] rows = new bool[m];
            bool[] cols = new bool[n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        rows[i] = true;
                        cols[j] = true;
                    }
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (rows[i] || cols[j])
                    {
                        matrix[i][j] = 0;
                    }
                }
            }

        }
        public void Show(int[][] matrix)
        {
            int m = matrix.Length;//行数
            int n = matrix[0].Length;//列数
            for (int i = 0; i < m; i++)
            {
                Console.Write("[");
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i][j]}");
                    if (j < n - 1)
                    {
                        Console.Write(",");
                    }
                }
                Console.WriteLine("]");
            }
        }
    }
}
