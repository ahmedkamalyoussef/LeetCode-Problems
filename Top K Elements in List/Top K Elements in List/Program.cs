namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 1, 1, 2, 2, 2, 3, 3, 3 };
            int k = 3;
            int[] result = new int[k];
            Array.Sort(nums);
            var num = new List<int>();
            int helper = 0;
            for (int v = 0; v < k; v++)
            {
                int tmf = int.MinValue;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (!num.Contains(nums[i]))
                    {
                        var mfCount = 0;
                        for (int j = 0; j < nums.Length; j++)
                        {
                            if (nums[i] == nums[j])
                                mfCount++;
                        }
                        if (mfCount >= tmf)
                        {
                            tmf = mfCount;
                            helper = nums[i];
                        }
                    }
                }
                num.Add(helper);
                result[v] = helper;
            }
            Array.Sort(result);
            //return result;
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}