using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCodes.Factory
{
    class Divide : ICalculate
    {
        public void Calculate(double num1, double num2)
        {
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
        }
    }
}
