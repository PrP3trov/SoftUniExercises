using System;
using System.Xml.Schema;

namespace Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int totaltime = hours * 60 + minutes + 15;
            int hourstime = totaltime / 60; // 2
            int minutestime = totaltime % 60; //1
            if(hourstime >= 24)
            {
                hourstime = 0;
            }
            if(minutestime < 10)
            {
                Console.WriteLine($"{hourstime}:0{minutestime}");
            }
            else Console.WriteLine($"{hourstime}:{minutestime}");

        }
    }
}
