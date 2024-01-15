int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

int rows = size[0];
int cols = size[1];

int count = 0;

string[] previousRow = null;
for (int i = 0; i < rows; i++)
{
    string[] currentRow = Console.ReadLine().Split();
    
    if (i > 0)
    {
        for (int j = 0; j < cols-1; j++)
        {
            if (currentRow[j] == previousRow[j] && currentRow[j] == previousRow[j+1] && currentRow[j+1] == previousRow[j])
            {
                count++;
            }
        }
    }

    previousRow = currentRow;
}
Console.WriteLine(count);