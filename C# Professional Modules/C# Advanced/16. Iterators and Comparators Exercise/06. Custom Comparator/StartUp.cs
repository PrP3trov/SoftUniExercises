namespace _06._Custom_Comparator
{
    public class StartUp
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(arr, new Comparator());
            Console.WriteLine(string.Join(" ", arr));
        }
    }
    public class Comparator : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            int compare = Math.Abs(x % 2).CompareTo(Math.Abs(y % 2));
            if (compare == 0)
            {
                compare = x.CompareTo(y);
            }
            return compare;
        }
    }
}