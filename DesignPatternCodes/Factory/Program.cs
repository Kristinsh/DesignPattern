using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCodes.Factory
{
    class Program
    {
       static void Main()
        {
            Console.WriteLine("Write a number");
            var input = Console.ReadLine();

            double num1, num2;
            var result = Double.TryParse(input, out num1);
            if(!result)
            {
                Console.WriteLine("Error, write a number");
                return;
            }


            Console.WriteLine("Write another number");
            result = Double.TryParse(Console.ReadLine(), out num2);
            if(!result)
            {
                Console.WriteLine("error, write a number");
                return; 
            }

            Console.WriteLine("Type +, / or -");
            CalculateFactory calculateFactory = new CalculateFactory();
            ICalculate obj = calculateFactory.GetCalculation(Console.ReadLine());
            obj.Calculate(num1, num2);
            Main();
        }

    }
}
