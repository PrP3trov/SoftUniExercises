using System;

namespace _0._1_Read_Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            while (n != "Stop")
            {
                Console.WriteLine(n);
                n = Console.ReadLine();
            }
        }
    }
}
