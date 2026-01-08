namespace hot_矩阵_旋转图像
{
    //给定一个 n × n 的二维矩阵 matrix 表示一个图像。请你将图像顺时针旋转 90 度。
    //你必须在 原地 旋转图像，这意味着你需要直接修改输入的二维矩阵。请不要 使用另一个矩阵来旋转图像。
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new();
            int[][] matrix = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
            Show(matrix);
            s.Rotate(matrix);
            Show(matrix);
        }
        public static void Show(int[][] matrix)
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
        public void my()
        {

            //int cs = n + 1 / 2;
            //int top = 0, left = 0, right = n - 1, bottom = n - 1;
            //while (top < bottom && left < right)
            //{
            //    int[] topNums = new int[right - left + 1];
            //    for (int i = left; i <= right; i++)//上
            //    {
            //        topNums[i] = matrix[top][i];
            //        matrix[top][i] = matrix[bottom - i][left];
            //    }

            //    for (int i = top; i <= bottom; i++)
            //    {
            //        matrix[i][right] = matrix[top][i];
            //    }
            //    for (int i = right; i >= left; i--)
            //    {
            //        matrix[bottom][right - i] = matrix[i][right];
            //    }
            //    for (int i = bottom; i >= top; i--)
            //    {
            //        matrix[left][bottom - i] = topNums[i];
            //    }

            //    top++;
            //    left++;
            //    right--;
            //    bottom--;
        }
    }
}
public class Solution
{
    public void Rotate(int[][] matrix)
    {
        //
        int n = matrix.Length;
        for (int i = 0; i < n / 2; i++)
        {
            for (int j = 0; j < (n + 1) / 2; j++)
            {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[n - j - 1][i];
                matrix[n - j - 1][i] = matrix[n - 1 - i][n - j - 1];
                matrix[n - i - 1][n - j - 1] = matrix[j][n - i - 1];
                matrix[j][n - i - 1] = temp;
            }
        }
    }



}
