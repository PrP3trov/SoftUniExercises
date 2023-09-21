using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            int attempts = 0;
            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }
            while (true) 
            {
                string a = Console.ReadLine();
                if (a == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                attempts++;
                if (attempts == 4) { Console.WriteLine($"User {username} blocked!"); break; }
                else Console.WriteLine("Incorrect password. Try again.");             
            }
        }
    }
}
