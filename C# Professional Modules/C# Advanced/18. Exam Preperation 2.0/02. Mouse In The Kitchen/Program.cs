using System.Numerics;

namespace _02._Mouse_In_The_Kitchen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
            int mouseRow = -1;
            int mouseCol = -1;
            int cheese = 0;
            char[,] matrix = new char[dimentions[0], dimentions[1]];
            for (int i = 0; i < dimentions[0]; i++)
            {
                string newRow = Console.ReadLine();
                for (int j = 0; j < dimentions[1]; j++)
                {
                    matrix[i, j] = newRow[j];
                    if (newRow[j] == 'M')
                    {
                        mouseCol = j;
                        mouseRow = i;
                        matrix[mouseRow, mouseCol] = '*';
                    }
                    if (newRow[j] == 'C')
                    {
                        cheese++;
                    }
                }
            }
            string command;
            while ((command = Console.ReadLine()) != "danger")
            {
                if (command == "up" && mouseRow == 0 || command == "down" && mouseRow == dimentions[0] - 1 ||
                    command == "left" && mouseCol == 0 || command == "right" && mouseCol == dimentions[1] - 1)
                {
                    Console.WriteLine("No more cheese for tonight!");
                    break;
                }
                else
                {
                    switch(command)
                    {
                        case "left" when matrix[mouseRow, mouseCol - 1] == '@':
                        case "right" when matrix[mouseRow, mouseCol + 1] == '@':
                        case "up" when matrix[mouseRow-1, mouseCol] == '@':
                        case "down" when matrix[mouseRow+1, mouseCol] == '@':
                            continue;
                        case "up":
                            mouseRow--;
                            break;
                        case "down":
                            mouseRow++;
                            break;
                        case "right":
                            mouseCol++;
                            break;
                        case "left":
                            mouseCol--;
                            break;
                    }
                    if (matrix[mouseRow,mouseCol] == 'C')
                    {
                        cheese--;
                        matrix[mouseRow, mouseCol] = '*';
                        if (cheese == 0)
                        {
                            matrix[mouseRow, mouseCol] = 'M';
                            Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                            break;
                        }
                        continue;
                    }
                    if (matrix[mouseRow,mouseCol] == 'T')
                    {
                        Console.WriteLine("Mouse is trapped!");
                        break;
                    }                   
                }                
            }
            if (command == "danger")
            {
                Console.WriteLine("Mouse will come back later!");
            }
            matrix[mouseRow, mouseCol] = 'M';
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