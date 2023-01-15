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
            try
            {
                Console.WriteLine(calc.Calculate(input));
            }
            catch (CalcException e)
            {
                Console.WriteLine("ошибка при вводе данных: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("при работе программы возникло исключение: " + e.Message);
            }
        }
    }
}

