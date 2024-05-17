namespace _02._Clear_Skies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int jetCol = -1;
            int jetRow = -1;
            int enemyJets = 0;
            int armor = 300;
            for (int i = 0; i < n; i++)
            {
                string arayRow = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = arayRow[j];
                    if (matrix[i, j] == 'J')
                    {
                        jetCol = j; 
                        jetRow = i; 
                        matrix[i, j] = '-';
                    }
                    if (matrix[i, j] == 'E')
                    {
                        enemyJets++;
                    }
                }
            }
            while (enemyJets > 0 && armor > 0)
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "up":
                        jetRow--;
                        break;
                    case "down":
                        jetRow++;
                        break;
                    case "right":
                        jetCol++;
                        break;
                    case "left":
                        jetCol--;
                        break;
                }
                if (matrix[jetRow,jetCol] == 'E')
                {
                    matrix[jetRow, jetCol] = '-';
                    enemyJets--;
                    if (enemyJets == 0)
                    {
                        Console.WriteLine("Mission accomplished, you neutralized the aerial threat!");
                        matrix[jetRow, jetCol] = 'J';
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                Console.Write(matrix[i, j]);
                            }
                            Console.WriteLine();
                        }
                        return;
                    }
                    else
                    {
                        armor -= 100;
                        if (armor == 0)
                        {
                            Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{jetRow}, {jetCol}]!");
                            matrix[jetRow, jetCol] = 'J';
                        }
                    }
                }
                if (matrix[jetRow, jetCol] == 'R')
                {
                    armor = 300;
                    matrix[jetRow, jetCol] = '-';
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}