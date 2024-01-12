int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[n,n];
int sum = 0;

for (int i = 0; i < n; i++)
{
    int[] arayRow = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
    for (int j = 0; j < n; j++)
    {
        matrix[i,j] = arayRow[j];
    }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    sum += matrix[i,i];
}
Console.WriteLine(sum);