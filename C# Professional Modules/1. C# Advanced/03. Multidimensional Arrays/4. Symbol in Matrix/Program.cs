int rows = int.Parse(Console.ReadLine());

int[,] matrix = new int[rows, rows];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    char[] row = Console.ReadLine().ToArray();
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = row[j];
    }
}
char symbol = char.Parse(Console.ReadLine());
int check = (int)(symbol);
int symbolRow = -1;
int symbolCol = -1;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i,j] == check)
        {
            symbolRow = i;
            symbolCol = j;
            check = int.MinValue;
        }
    }
}
if (symbolRow < 0 || symbolCol < 0)
{
    Console.WriteLine($"{symbol} does not occur in the matrix");
}
else
{
    Console.WriteLine($"({symbolRow}, {symbolCol})");
}