using System;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter the numbers:");
            string n1 = Console.ReadLine();
            string n2 = Console.ReadLine();
            int.TryParse(n1, out num1);
            int.TryParse(n2, out num2);
            int res = num1 + num2;
            Console.WriteLine("{0} + {1} = {2}", num1, num2, res);
            Console.Read();
        }
    }
}
