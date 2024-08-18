namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> arrays = [];
            arrays.Add([-1, 1]);
            arrays.Add([-3, 1, 4]);
            arrays.Add([-2, -1, 0, 2]);
            int min = arrays[0][0];
            int max = arrays[0][arrays[0].Count - 1];
            int dis = int.MinValue;
            for (int i = 1; i < arrays.Count; i++)
            {
                int currentMin = arrays[i][0];
                int currentMax = arrays[i][arrays[i].Count - 1];
                dis = Math.Max(dis, Math.Max(currentMax - min, max - currentMin));
                min = Math.Min(min, currentMin);
                max = Math.Max(max, currentMax);
            }
            Console.WriteLine(dis);
        }
    }
}