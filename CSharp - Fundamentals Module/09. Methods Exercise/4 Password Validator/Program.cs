using System;

namespace _4_Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool valid = CointsCharacters(password);
            bool valid1= OnlyLettersAndDigidts(password);
            bool valid2 = AtLeast2Digits(password);
            if (valid1 && valid2 && valid)
            {
                Console.WriteLine("Password is valid");
            }
        }

          static bool OnlyLettersAndDigidts(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                
                if (Char.IsLetterOrDigit(password[i]))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    return false;                  
                }
            }
            return true;

        }

         static bool AtLeast2Digits(string password)
        {
            int total = 0;
            for (int i = 0; i < password.Length; i++)
            {                    
                if (Char.IsDigit(password[i]))
                {
                    total++;
                }
            }
            if (total < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                return false;
            } 
            else return true;
        }

         static bool CointsCharacters(string password)
        {
            if (password.Length < 6)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;

            }
            else if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else return false;
        }
    }
}
