namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strs = new[] { "act", "cat", "hat" };
            var list = new List<List<string>>();
            var added = new List<string>();
            foreach (var str in strs)
            {
                if (added.Contains(str))
                    continue;
                var arr = new List<string>();
                var str1Arr = str.ToCharArray();
                Array.Sort(str1Arr);
                foreach (var str2 in strs)
                {
                    var str2Arr = str2.ToCharArray();
                    Array.Sort(str2Arr);
                    if (str.Length == str2.Length && new string(str1Arr) == new string(str2Arr))
                    {
                        arr.Add(str2);
                        added.Add(str2);
                    }
                }
                if (arr.Count > 0)
                    list.Add(arr);
            }
            //return list;

            foreach (var strss in list)
            {
                foreach (var str in strss)
                {
                    Console.Write($"{str} - ");
                }
                Console.WriteLine();
            }
        }
    }
}