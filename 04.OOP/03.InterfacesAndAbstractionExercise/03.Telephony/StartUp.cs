namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var phoneNumbers = Console.ReadLine().Split();
            var urls = Console.ReadLine().Split();

            foreach (var phoneNumber in phoneNumbers)
            {
                if (IsValidPhoneNumber(phoneNumber))
                {
                    ICaller phone;

                    if (phoneNumber.Length == 7)
                    {
                        phone = new StationaryPhone();
                    }
                    else
                    {
                        phone = new Smartphone();
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
                if (IsValidURL(url))
                {
                    IBrowser phone = new Smartphone();
                    phone.Browse(url);
                }
                else
                {
                    Console.WriteLine("Invalid URL!");
                }
            }
        }

        private static bool IsValidPhoneNumber(string phoneNumber)
        {
            return phoneNumber.All(char.IsDigit);
        }

        private static bool IsValidURL(string url)
        {
            return !url.Any(char.IsDigit);
        }
    }
}