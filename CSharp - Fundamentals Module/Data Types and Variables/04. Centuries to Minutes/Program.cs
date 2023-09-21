int n = int.Parse(Console.ReadLine());
int years = n * 100;
double days = years * 365.2422;
int days1 = (int)days;
int hours = days1 * 24;
int minutes = hours * 60;
Console.Write($"{n} centuries = {years} years = {days1} days = {hours} hours = {minutes} minutes");