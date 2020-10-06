using System;

namespace q2
{
    class Item
    {
        private string name;
        public static decimal cost;
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
            item.Name = "Shoes";
            Item.cost = 1499M;
            Console.WriteLine("GST is "+item.CalcGst());
        }
    }
}
