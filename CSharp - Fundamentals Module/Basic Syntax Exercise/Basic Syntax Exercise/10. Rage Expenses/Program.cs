int lostgames = int.Parse(Console.ReadLine());
double headsetPrice  = double.Parse(Console.ReadLine());
double mousePrice  = double.Parse(Console.ReadLine());
double keyboardPrice  = double.Parse(Console.ReadLine());
double displayPrice  = double.Parse(Console.ReadLine());
int headsets = lostgames / 2;
int mouses = lostgames / 3;
int keyboards = lostgames / 6;
int displays = lostgames / 12;
double sum = headsetPrice * headsets + mousePrice * mouses + keyboardPrice * keyboards + displayPrice * displays;
Console.WriteLine($"Rage expenses: {sum:F2} lv.");

