using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Service.Interface
{
    public interface ICalculation
    {
        public void Operation(int num1, int num2, string op);
        
    }
}
