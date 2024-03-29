﻿namespace _04.PizzaCalories
{
    public class Dough
    {
        private const double BaseCalories = 2.0;

		private readonly string flourType;
        private readonly string bakingTechnique;
        private readonly double weight;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
			Weight = weight;
        }

        public string FlourType
		{
			get => flourType;
			init
			{
				if (value.ToLower() is not ("white" or "wholegrain"))
				{
					throw new ArgumentException("Invalid type of dough.");
				}

				flourType = value;
			}
		}

		public string BakingTechnique
		{
			get => bakingTechnique;
			init
			{
                if (value.ToLower() is not ("crispy" or "chewy" or "homemade"))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                bakingTechnique = value;
			}
		}

		public double Weight
		{
			get => weight;
			init
			{
				if (value is < 1 or > 200)
				{
					throw new ArgumentException("Dough weight should be in the range [1..200].");
				}

				weight = value;
			}
		}

		public double CaloriesPerGram
		{
			get
			{
				double calsPerGram = BaseCalories;

				if (FlourType.ToLower() == "white")
				{
					calsPerGram *= 1.5;
				}
				else if (FlourType.ToLower() == "wholegrain")
				{
					calsPerGram *= 1.0;
				}

				switch (bakingTechnique.ToLower())
				{
					case "crispy":
                        calsPerGram *= 0.9; break;
					case "chewy":
						calsPerGram *= 1.1; break;
					case "homemade":
						calsPerGram *= 1.0; break;
				}

				return calsPerGram;
			}
		}
    }
}