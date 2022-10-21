using Calculator.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Service
{
    public class Calculation : ICalculation
    {
        public void Operation(int num1, int num2, string op)
        {
             int result = 0;


            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;

                case "-":
                    result = num1 - num2;
                    break;

                case "*":
                    result = num1 * num2;
                    break;

                case "/":
                    result = num1 / num2;
                    break;
            }

            Console.WriteLine(result);
        }
    }
}
