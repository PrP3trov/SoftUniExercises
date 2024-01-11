using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameArchitect = Console.ReadLine();
            int numberProjects = int.Parse(Console.ReadLine());
            int hoursNeeded = numberProjects * 3;
            Console.WriteLine($"The architect {nameArchitect} will need {hoursNeeded} hours to complete {numberProjects} project/s.");
        }
    }
}