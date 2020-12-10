using System;

namespace q2
{
    class Item
    {
        private static decimal cost;
        public static decimal Cost
        {
            get
            {
                return cost;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid. Only positive decimals accepted.");
                }
                else
                    cost = value;
            }
        }
        public string Name { get; set; }
        public decimal CalcGst()
        {
            return 0.08M * cost;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Item item = new Item();
            Console.WriteLine("Enter item name and cost: ");
            item.Name = Console.ReadLine();
            decimal cost;
            Decimal.TryParse(Console.ReadLine(), out cost);
            Item.Cost = cost;
            Console.WriteLine("GST of {0} costing {1} is {2} ", item.Name, Item.Cost, item.CalcGst());
        }
    }
}
