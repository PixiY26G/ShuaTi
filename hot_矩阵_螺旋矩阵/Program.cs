namespace hot_矩阵_螺旋矩阵
{
    //给你一个 m 行 n 列的矩阵 matrix ，请按照 顺时针螺旋顺序 ，返回矩阵中的所有元素。
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
            Solution s = new();
            IList<int> ints = s.SpiralOrder(matrix);
            foreach (var num in ints)
            {
                Console.WriteLine(num + " ");
            }
        }
        public class Solution
        {
            public IList<int> SpiralOrder(int[][] matrix)
            {
                List<int> ints = new();
                int m = matrix.Length;
                int n = matrix[0].Length;
                int top = 0, bottom = m - 1, left = 0, right = n - 1;
                int num = m * n;

                while (top <= bottom && left <= right)
                {
                    for (int i = left; i <= right; i++)
                    {
                        ints.Add(matrix[top][i]);
                    }
                    top++;
                    for (int i = top; i <= bottom; i++)  // 修正了索引计算
                    {
                        ints.Add(matrix[i][right]);
                    }
                    right--;  // 右边界左移

                    // 从右到左遍历底部行（确保还有行）
                    if (top <= bottom)
                    {
                        for (int i = right; i >= left; i--)  // 修正了索引计算
                        {
                            ints.Add(matrix[bottom][i]);
                        }
                        bottom--;  // 下边界上移
                    }

                    // 从下到上遍历左侧列（确保还有列）
                    if (left <= right)
                    {
                        for (int i = bottom; i >= top; i--)  // 修正了索引计算
                        {
                            ints.Add(matrix[i][left]);
                        }
                        left++;  // 左边界右移
                    }
                }



                return ints;
            }
        }
    }
}
