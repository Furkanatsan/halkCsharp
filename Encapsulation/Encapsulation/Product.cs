namespace Encapsulation
{
    public class Product
    {
        private double price;
        public void SetPrice(double value)
        {
            if (value > 0)
            {
                price = value;
            }
            else
            {
                throw new ArgumentException($"fiyat değeri 0 ve altında olamaz");
            }

        }

        public double GetPrice()
        {
            return price;
        }

        private string name;
        //Property:
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description { get; set; }
        public int StockLevel { get { return 100; } }



    }
}
