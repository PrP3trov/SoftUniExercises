using System;

namespace On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chasIspit = int.Parse(Console.ReadLine());
            int minutaIspit = int.Parse(Console.ReadLine());
            int chasPristiga = int.Parse(Console.ReadLine());
            int minutaPristiga = int.Parse(Console.ReadLine());
            int ispitVMinuti = chasIspit * 60 + minutaIspit;
            int pristigaMinuti = chasPristiga * 60 + minutaPristiga;
            int navreme = ispitVMinuti - pristigaMinuti;
            int kusno = pristigaMinuti - ispitVMinuti;
            double minuti = 0;
            double chas = 0;
            if (pristigaMinuti > ispitVMinuti)
            {
                Console.WriteLine("Late");
                if (kusno >= 60)
                {
                    chas = kusno / 60; // chas
                    minuti = kusno % 60;
                    if (minuti <= 9)
                    {
                        Console.WriteLine($"{chas}:0{minuti} hours after the start");
                    }
                    else { Console.WriteLine($"{chas}:{minuti} hours after the start"); }
                }
            else { Console.WriteLine($"{kusno} minutes after the start");}
            }
            else if (pristigaMinuti == ispitVMinuti || navreme <= 30)
            {
                if (navreme == 0 )Console.WriteLine($"On time");
                else { Console.WriteLine("On time"); Console.WriteLine($"{navreme} minutes before the start"); }

            }
            else if (navreme > 30)
            {
                Console.WriteLine("Early");
                if (navreme >= 60)
                {
                    chas = navreme / 60; // chas 1 
                    minuti = navreme % 60; // 0
                    if (minuti <= 9)
                    {
                        Console.WriteLine($"{chas}:0{minuti} hours before the start");
                    }
                    else { Console.WriteLine($"{chas}:{minuti} hours before the start"); }
                }
                else { Console.WriteLine($"{navreme} minutes before the start"); }
            }

        }
    }
}
