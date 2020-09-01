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
            Console.WriteLine("The results of arithmetic operations on the two numbers are: \n{0} + {1} = {2}\n{0} - {1} = {3}\n{0} * {1} = {4}\n{0} / {1} = {5}", num1, num2, num1+num2, num1-num2, num1*num2, num1/num2);
            Console.Read();
        }
    }
}
