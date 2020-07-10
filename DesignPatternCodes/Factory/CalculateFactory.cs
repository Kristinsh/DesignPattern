using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCodes.Factory
{
    class CalculateFactory
    {
        public ICalculate GetCalculation(string type) 
        {
            ICalculate obj = null;
            
            if(type.ToLower().Equals("+"))
            {
                obj = new Add();
            }
            else if (type.ToLower().Equals("/"))
            {
                obj = new Divide();
            }
            else if (type.ToLower().Equals("-"))
            {
                obj = new Add();
            }
            else
            {
                Console.WriteLine("Error");
            }
            return obj;
        }
    }
}
