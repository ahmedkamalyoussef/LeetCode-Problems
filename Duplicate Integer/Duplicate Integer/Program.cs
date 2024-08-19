namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [1, 2, 3];
            for (var i = 0; i < nums.Length; i++)
            {
                for (var n = 0; n < nums.Length; n++)
                {
                    if (nums[i] == nums[n] && i != n)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}