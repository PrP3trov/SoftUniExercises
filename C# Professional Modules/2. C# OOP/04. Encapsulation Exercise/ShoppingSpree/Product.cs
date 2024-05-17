namespace ShoppingSpree
{
    public class Product
    {
		private string name;
		private int cost;
        public Product(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }
        public int Cost
		{
			get { return cost; }
			set 
			{
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                cost = value; 
			}
		}
		public string Name
		{
			get { return name; }
			set
			{
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
			}
		}

	}
}
