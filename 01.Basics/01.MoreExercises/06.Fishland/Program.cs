using System;

namespace _06.Fishland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var skumriqCena = double.Parse(Console.ReadLine());
            var cacaCena = double.Parse(Console.ReadLine());

            var palamudKg = double.Parse(Console.ReadLine());
            var safridKg = double.Parse(Console.ReadLine());
            var midiKg = double.Parse(Console.ReadLine());

            var palamudCena = skumriqCena + (skumriqCena * 0.6);
            var safridCena = cacaCena + (cacaCena * 0.8);
            var midiCena = 7.5;

            var total = (palamudKg * palamudCena) + (safridKg * safridCena) + (midiKg * midiCena);

            Console.WriteLine("{0:f2}", total);

        }
    }
}
