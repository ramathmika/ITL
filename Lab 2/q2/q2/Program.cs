using System;

namespace q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the date: ");
            string dateTime = Console.ReadLine();
            Console.WriteLine("Enter the number of ticks: ");
            int ticks;
            int.TryParse(Console.ReadLine(), out ticks);

        }
    }
}
