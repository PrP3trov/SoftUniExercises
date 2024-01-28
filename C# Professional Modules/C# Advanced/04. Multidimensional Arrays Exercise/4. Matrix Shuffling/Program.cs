using System.Numerics;
using System.Runtime.ExceptionServices;

int[] size = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int rows = size[0];
int cols = size[1];

string[,] matrix = new string[rows, cols];


for (int row = 0; row < rows; row++)
{
    string[] newRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
	for (int col = 0; col < cols; col++)
	{
		matrix[row, col] = newRow[col];
	}
}

while (true)
{
	string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

	if (command[0] == "END")
	{
		break;
	}
	if (command[0] == "swap" && command.Length == 5)
	{
		int row1 = int.Parse(command[1]);
		int col1 = int.Parse(command[2]);
		int row2 = int.Parse(command[3]);
		int col2 = int.Parse(command[4]);

		if (IsValidSwap(matrix, row1, col1, row2, col2))
		{
			string temp = matrix[row1, col1];
			matrix[row1,col1] = matrix[row2,col2];
			matrix[row2,col2] = temp;

			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				for (int col = 0; col < matrix.GetLength(1); col++)
				{
					Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine();
            }
		}
		else
		{
            Console.WriteLine("Invalid input!");
        }
	}
	else
	{
        Console.WriteLine("Invalid input!");
    }
}

static bool IsValidSwap(string[,] matrix, int row1, int col1, int row2, int col2)
{
	return row1 >= 0 && row1 < matrix.GetLength(0) && col1 >= 0 && col1 < matrix.GetLength(1) && row2 >= 0 && row2 < matrix.GetLength(0)
		&& col2 >= 0 && col2 < matrix.GetLength(1);
}