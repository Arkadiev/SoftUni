using static _06.StoreBoxes.Program;

namespace _06.StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] arguments = input.Split();
                string serialNumber = arguments[0];
                string itemName = arguments[1];
                int itemQuantity = int.Parse(arguments[2]);
                decimal itemPrice = decimal.Parse(arguments[3]);

                Box box = new Box();
                box.SerialNumber = serialNumber;
                box.ItemName = itemName;
                box.ItemQuantity = itemQuantity;
                box.ItemPrice = itemPrice;
                box.BoxPrice = itemQuantity * itemPrice;

                boxes.Add(box);

            }

            List<Box> boxesSorted = boxes.OrderByDescending(boxes => boxes.BoxPrice).ToList();

            foreach (Box box in boxesSorted)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.ItemName} - ${box.ItemPrice:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.BoxPrice:f2}");
            }

        }

        public class Box
        {
            public string SerialNumber { get; set; }

            public string ItemName { get; set; }

            public int ItemQuantity { get; set; }

            public decimal ItemPrice {  get; set; }

            public decimal BoxPrice { get; set; }
        }
    }
}