namespace _03.ShoppingSpree
{
    public class Product
    {
		private string name;
        private int price;

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public string Name
		{
			get => name;
			set
			{
				if(string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("Name cannot be empty");
				}

				name = value;
			}
		}

		public int Price
		{
			get => price;
			set
			{
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                price = value;
			}
		}

	}
}