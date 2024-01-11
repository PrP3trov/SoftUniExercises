using System;
using System.Reflection.Metadata.Ecma335;

namespace World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());
            double trqbvaPluva = meters * time;
            int vseki15metra = (int)meters / 15;
            double vseki15metra1 = vseki15metra * 12.5;
            double sumtime = trqbvaPluva + vseki15metra1;
            if ( record <= sumtime)
            {
                double timetrq = sumtime - record;
                Console.WriteLine($"No, he failed! He was {timetrq:F2} seconds slower.");
            }
            else if (record > sumtime)
            {

                Console.WriteLine($"Yes, he succeeded! The new world record is {sumtime:F2} seconds.");

            }
        }
    }
}
