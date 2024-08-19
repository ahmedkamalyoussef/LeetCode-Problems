namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s, t;
            if (s.Length != t.Length)
                return false;
            foreach (var letter in s)
            {
                int count1 = 0;
                int count2 = 0;

                if (!t.Contains(letter))
                    return false;
                foreach (var l in t)
                {
                    if (letter == l) count1++;
                }
                foreach (var l in s)
                {
                    if (letter == l) count2++;
                }
                if (count1 != count2) return false;
            }

            return true;
        }
    }
}