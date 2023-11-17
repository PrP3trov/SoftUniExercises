using System.Runtime.InteropServices;

int n = int.Parse(Console.ReadLine());
string bigest = "";
double volume = 0;
for (int i = 0; i < n; i++)
{
    string model = Console.ReadLine();
    double r = double.Parse(Console.ReadLine());
    int h = int.Parse(Console.ReadLine());
    double volume1 = Math.PI * (r * r) * h;
    if (volume1 > volume)
    {
        bigest = model;
        volume = volume1;
    }
}
Console.WriteLine(bigest);