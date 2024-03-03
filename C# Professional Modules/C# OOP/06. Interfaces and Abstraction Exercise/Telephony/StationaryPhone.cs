namespace Telephony
{
    public class StationaryPhone : ICaller
    {
        public void Call(string phoneNumber)
        {
            Console.WriteLine($"Dialing... {phoneNumber}");
        }
    }
}
