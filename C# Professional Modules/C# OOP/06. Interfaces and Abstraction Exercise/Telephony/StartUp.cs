namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] phones = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] urls = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var phoneNumber in phones)
            {
                ICaller phone;
                if (IsValidPhoneNumber(phoneNumber))
                {
                    if (phoneNumber.Length == 7)
                    {
                        phone = new StationaryPhone();
                    }
                    else
                    {
                        phone = new SmartPhone();
                    }
                    phone.Call(phoneNumber);
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }
            foreach (var url in urls)
            {
                if (IsUrlValid(url))
                {
                    SmartPhone smartPhone = new SmartPhone();
                    smartPhone.Browse(url);
                }
                else
                {
                    Console.WriteLine("Invalid URL!");
                }
            }
        }

        private static bool IsUrlValid(string url)
        {
            return !url.Any(char.IsDigit);
        }

        private static bool IsValidPhoneNumber(string phoneNumber)
        {
            return phoneNumber.All(char.IsDigit);
        }
    }
}