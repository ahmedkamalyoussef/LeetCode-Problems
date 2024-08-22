namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new[] { 1, 2, 4, 6 };
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                int multiply = 1;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j)
                        continue;
                    multiply *= nums[j];
                }
                result[i] = multiply;
            }

            foreach (var VARIABLE in result)
            {
                Console.WriteLine(VARIABLE);
            }
        }
    }
}