namespace Telephony
{
    public class StationaryPhone : ICaller
    {
        public void Call(string number)
        {
            Console.WriteLine($"Dialing... {number}");
        }
    }
}