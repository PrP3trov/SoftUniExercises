int rows = int.Parse(Console.ReadLine());

int[][] jaggedArray = new int[rows][];

for (int row = 0; row < jaggedArray.GetLength(0); row++)
{
    jaggedArray[row] = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

}

for (int row = 0; row < jaggedArray.GetLength(0)-1; row++)
{
    if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
    {
        for (int i = 0; i < jaggedArray[row].Length; i++)
        {
            jaggedArray[row][i] *= 2;
            jaggedArray[row + 1][i] *= 2;
        }
    }
    else
    {
        for (int i = 0; i < jaggedArray[row].Length; i++)
        {
            jaggedArray[row][i] /= 2;
        }
        for (int i = 0; i < jaggedArray[row+1].Length; i++)
        {
            jaggedArray[row+1][i] /= 2;
        }
    }
}

string[] command = Console.ReadLine().Split();
while (command[0] != "End")
{
    if (command[0]== "Add")
    {
        if (ValidateIndex(jaggedArray,command))
        {
            jaggedArray[int.Parse(command[1])][int.Parse(command[2])] += int.Parse(command[3]);
        }
    }
    if (command[0] == "Substract")
    {
        if (ValidateIndex(jaggedArray, command))
        {
            jaggedArray[int.Parse(command[1])][int.Parse(command[2])] -= int.Parse(command[3]);
        }
    }

}
for (int row = 0; row < jaggedArray.GetLength(0); row++)
{
    for (int col = 0; col < jaggedArray[row].Length; col++)
    {
        Console.Write(jaggedArray[row][col]+ " ");
    }
    Console.WriteLine();
}

bool ValidateIndex(int[][] jaggedArray, string[] command)
{
    return int.Parse(command[1]) >= 0
        && int.Parse(command[1]) <= jaggedArray.GetLength(0)
        && int.Parse(command[2]) >= 0
        && int.Parse(command[2]) < jaggedArray[int.Parse(command[1])].Length;
}