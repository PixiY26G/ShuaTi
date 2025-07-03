namespace T2_移除元素
{
    //移除数组中的所有指定元素，且返回指定个数

    //}
    internal class Program
    {
        static public int RemoveElement(int[] nums, int val)
        {
            int k = 0;
            //int[] indexNums = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if (val != nums[i])
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            for (int i = k; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
            //nums = indexNums;
            return k;
        }
        static public int Remove(int[] nums, int val)
        {
            int k = 0; // 记录移除元素后数组的有效长度

            // 遍历数组
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    // 如果当前元素不等于 val，将其赋值给 nums[k]
                    nums[k] = nums[i];
                    k++; // k 指针向后移动一位
                }
            }

            return k;
        }
        static void Main(string[] args)
        {
            int[] nums = [3, 2, 2, 3]; // 输入数组
            int val = 3;
            int m = RemoveElement(nums, val);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{nums[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine(m);
        }
    }
}
