using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StringCalculatorNS;

namespace HW03_Calc_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new StringCalculator();

            string input = Console.ReadLine();
            Console.WriteLine(calc.Calculate(input));
        }
    }
}

