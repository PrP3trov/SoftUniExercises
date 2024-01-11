using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int br = 0;
           string booktursim = Console.ReadLine();
            while (true)
            {
                string book = Console.ReadLine();
               
                if (book == booktursim)
                {
                    Console.WriteLine($"You checked {br} books and found it.");
                    break;
                }
                if (book == "No More Books")
                {
                    Console.WriteLine($"The book you search is not here!");
                    Console.WriteLine($"You checked {br} books.");
                    break;
                }
                br++;
            }
        }
    }
}
