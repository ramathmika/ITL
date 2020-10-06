using System;

namespace q1
{
    public delegate void PriceChangedEventHandler(double price);
    class Item
    {
        private string name;
        private double price;
        public event PriceChangedEventHandler PriceChanged;

        public string Name { get; set; }
        public double Price {
            get
            {
                return price;
            }
            set
            {
                price = value;
                if (PriceChanged != null)
                    PriceChanged(value);
            } 
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Item item1 = new Item();
            Console.WriteLine("Enter the product name and price");
            item1.Name = Console.ReadLine();
            double price;
            double.TryParse(Console.ReadLine(), out price);
            item1.Price = price;
            item1.PriceChanged += ChangeDetected;
            item1.Price = item1.Price * 2;
        }

        public static void ChangeDetected(double price)
        {
            Console.WriteLine("New price is " + price);
        }
    }
}
