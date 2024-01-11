using System.Security.Cryptography.X509Certificates;

List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();
for (int i = 0; i < first.Count; i++)
{
    if (first[i] < 0)
    {
        first.RemoveAt(i);
        i = - 1;
    }
}
first.Reverse();
if (first.Count == 0)
{
    Console.WriteLine("empty");
}
else
{
    Console.WriteLine(string.Join(" ", first));
}
