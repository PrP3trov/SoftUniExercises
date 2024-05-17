using System.Formats.Asn1;

namespace _02._Fishing_Competition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int startCol = -1;
            int startRow = -1;
            int fish = 0;
            int whirlpool = 0;
            for (int i = 0; i < n; i++)
            {
                string arayRow = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = arayRow[j];
                    if (matrix[i, j] == 'S')
                    {
                        startCol = j; // 3
                        startRow = i; // 0
                        matrix[i, j] = '-';

                    }
                }
            }
            string command;
            while ((command = Console.ReadLine()) != "collect the nets")
            {
                if (command == "up" && startRow == 0)
                {
                    startRow = matrix.GetLength(0) - 1;
                }
                else if (command == "down" && startRow == matrix.GetLength(0) - 1)
                {
                    startRow = 0;
                }
                else if (command == "right" && startCol == matrix.GetLength(1) - 1)
                {
                    startCol = 0;
                }
                else if (command == "left" && startCol == 0)
                {
                    startCol = matrix.GetLength(1) - 1;
                }
                else
                {
                    switch (command)
                    {
                        case "up":
                            startRow--;
                            break;
                        case "down":
                            startRow++;

                            break;
                        case "right":
                            startCol++;
                            break;
                        case "left":
                            startCol--;
                            break;
                    }
                }
                    char compare = matrix[startRow, startCol];
                    if (Char.IsDigit(compare))
                    {
                        fish += int.Parse(compare.ToString());
                        matrix[startRow, startCol] = '-';
                    }
                    if (compare == 'W')
                    {
                        Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{startRow},{startCol}]");
                        fish = 0;
                        whirlpool++;
                        return;
                    }
                }
            matrix[startRow, startCol] = 'S';
            
            if (fish >= 20)
            {
                Console.WriteLine("Success! You managed to reach the quota!");
            }
            else
            {
                     
                Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {20 - fish} tons of fish more.");
            }
            if (fish > 0)
            {
                Console.WriteLine($"Amount of fish caught: {fish} tons.");
            }
            if (whirlpool == 0)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i,j]);
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}