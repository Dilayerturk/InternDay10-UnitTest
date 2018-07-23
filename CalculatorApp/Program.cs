using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Double.Parse(args[0]);
            double b = Double.Parse(args[1]);

            Calculator calculator = new Calculator();

            double result = calculator.Plus(a, b);

            Console.WriteLine(result);
        }
    }
}
