namespace _04.ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> stores = new();

            string input;
            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] arguments = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string store = arguments[0];
                string product = arguments[1];
                double price = double.Parse(arguments[2]);

                if (!stores.ContainsKey(store))
                {
                    stores.Add(store, new Dictionary<string, double>());
                }

                if (!stores[store].ContainsKey(product))
                {
                    stores[store].Add(product, 0);
                }

                stores[store][product] = price;
            }

            stores = stores.OrderBy(s => s.Key).ToDictionary(s => s.Key, s => s.Value);

            foreach (var (store, products) in stores)
            {
                Console.WriteLine($"{store}->");

                foreach (var (product, price) in products)
                {
                    Console.WriteLine($"Product: {product}, Price: {price}");
                }
            }
        }
    }
}