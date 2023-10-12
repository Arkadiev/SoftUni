namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                bool isNumberPalindrome = IsPalindrome(input);
                Console.WriteLine(isNumberPalindrome);
            }

        }

        static bool IsPalindrome(string symbols)
        {
            int left = 0;
            int right = symbols.Length - 1;

            while (left < right)
            {
                if (symbols[left] != symbols[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}