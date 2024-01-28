int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[n, n];

int sum1 = 0;

int sum2 = 0;

for (int i = 0; i < n; i++)
{
	int[] newRow = Console.ReadLine().Split().Select(int.Parse).ToArray();

	for (int j = 0; j < n; j++)
	{
		matrix[i, j] = newRow[j];

		if (i == j)
		{
			sum1 += matrix[i, j];
		}
	}

}

for (int k = 0; k < n; k++)
{
    sum2 += matrix[k, n - 1 - k];
}
Console.WriteLine(Math.Abs(sum1-sum2));