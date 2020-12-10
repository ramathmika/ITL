using System;

namespace q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter two numbers: ");
            int.TryParse(Console.ReadLine(), out num1);
            int.TryParse(Console.ReadLine(), out num2);
            Console.WriteLine("\nChoose one of the following arithmetic operation:");
            Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division.\n5. All\nChoice: ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("\n{0} + {1} = {2}", num1, num2, num1 + num2);
                    break;
                case 2:
                    Console.WriteLine("\n{0} - {1} = {2}", num1, num2, num1 - num2);
                    break;
                case 3:
                    Console.WriteLine("\n{0} * {1} = {2}", num1, num2, num1 * num2);
                    break;
                case 4:
                    Console.WriteLine("\n{0} / {1} = {2}", num1, num2, (double)num1 / num2);
                    break;
                case 5:
                    Console.WriteLine("\n{0} + {1} = {2}\n{0} - {1} = {3}\n{0} * {1} = {4}\n{0} / {1} = {5}", num1, num2, num1 + num2, num1 - num2, num1 * num2, (double)num1 / num2);
                    break;
                default:
                    Console.WriteLine("\nChoose a valid option");
                    break;
            }
            Console.Read();
        }
    }
}

