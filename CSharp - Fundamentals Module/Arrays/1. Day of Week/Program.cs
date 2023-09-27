string[] array = {  
    "Monday",
 "Tuesday",
 "Wednesday",
 "Thursday",
 "Friday",
 "Saturday",
 "Sunday"};int n = int.Parse(Console.ReadLine());if (n >=1 && n <= 7)
{
    Console.WriteLine(array[n-1]);
}
else Console.WriteLine("Invalid day!");