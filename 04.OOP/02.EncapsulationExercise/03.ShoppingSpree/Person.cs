namespace _03.ShoppingSpree
{
    public class Person
    {
		private string name;
        private int money;
        private List<Product> bag;

        public Person(string name, int money)
        {
            Name = name;
            Money = money;
			bag = new List<Product>();
        }

        public string Name
		{
			get => name;
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException($"Name cannot be empty");
				}

				name = value;
			}
		}

		public int Money
		{
			get => money;
			set
			{
				if (value < 0)
				{
					throw new ArgumentException("Money cannot be negative");
				}

				money = value;
			}
		}

		public List<Product> Bag => bag;

        public void AddProduct(Product product)
		{
			if (product.Price > this.Money)
			{
				throw new ArgumentException($"{this.Name} can't afford {product.Name}");
			}

			bag.Add(product);
			this.Money -= product.Price;
		}
	}
}