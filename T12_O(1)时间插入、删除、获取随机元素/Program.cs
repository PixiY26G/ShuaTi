namespace T12_O_1_时间插入_删除_获取随机元素
{
    public class RandomizedSet
    {
        List<int> lInts;
        Random random;
        public RandomizedSet()
        {
            lInts = new List<int>();
            random = new Random();
        }

        public bool Insert(int val)
        {
            if (lInts.Contains(val))
            {
                return false;
            }

            //for (int i = 0; i < lInts.Count; i++)
            //{
            //    if (lInts[i] == val)
            //    {
            //        return false;
            //    }
            //}
            lInts.Add(val);
            return true;
        }

        public bool Remove(int val)
        {
            if (lInts.Contains(val))
            {
                lInts.Remove(val);
                return true;
            }
            return false;
        }

        public int GetRandom()
        {

            int i = random.Next(0, lInts.Count);
            return lInts[i];
        }
    }
    public class Ans
    {
        IList<int> nums;
        Dictionary<int, int> indices;
        Random random;

        public Ans()
        {
            nums = new List<int>();
            indices = new Dictionary<int, int>();
            random = new Random();
        }

        public bool Insert(int val)
        {
            if (indices.ContainsKey(val))
            {
                return false;
            }
            int index = nums.Count;
            nums.Add(val);
            indices.Add(val, index);
            return true;
        }

        public bool Remove(int val)
        {
            if (!indices.ContainsKey(val))
            {
                return false;
            }
            int index = indices[val];
            int last = nums[nums.Count - 1];
            nums[index] = last;
            indices[last] = index;
            nums.RemoveAt(nums.Count - 1);
            indices.Remove(val);
            return true;
        }

        public int GetRandom()
        {
            int randomIndex = random.Next(nums.Count);
            return nums[randomIndex];
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
