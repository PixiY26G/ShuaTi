namespace T14_加油站
{
    public class Solution
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            int n = gas.Length;
            int j = 0;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = gas[i] - cost[i];
            }
            for (int i = 0; i < n; i++)
            {
                j += arr[i];
            }
            if (j < 0)
            {
                return -1;
            }
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    continue;
                }
                else
                {
                    for (int k = 0; k < n; k++)
                    {

                    }
                }
            }
            //for (int i = 0; i < n; i++)
            //{
            //    j += gas[i];
            //    j -= cost[i];
            //    if (j < 0)
            //    {
            //        return -1;
            //    }
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    if (gas[i] < cost[i])
            //    {
            //        continue;
            //    }
            //    return i;
            //}
            return -1;
        }
        public int Ans(int[] gas, int[] cost)
        {
            int n = gas.Length;
            int i = 0;
            while (i < n)
            {
                int sumOfGas = 0, sumOfCost = 0;
                int cnt = 0;
                while (cnt < n)
                {
                    int j = (i + cnt) % n;
                    sumOfGas += gas[j];
                    sumOfCost += cost[j];
                    if (sumOfCost > sumOfGas)
                    {
                        break;
                    }
                    cnt++;
                }
                if (cnt == n)
                {
                    return i;
                }
                else
                {
                    i = i + cnt + 1;
                }
            }
            return -1;
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
