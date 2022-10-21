using Calculator.Service;
using Calculator.Service.Interface;
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter operator");
            string op = Console.ReadLine();

            Console.WriteLine("Enter second number");
            int num2 = int.Parse(Console.ReadLine());

          

            ICalculation service = new Calculation();
            service.Operation(num1, num2, op);
        }
    }
}
