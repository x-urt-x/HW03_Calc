using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringCalculatorNS;
using PrimeNS;

namespace UINS
{
    public class UserInterface
    {
        StringCalculator calc;
        PrimeCalc primeCalc;

        public UserInterface() 
        {
            calc = new StringCalculator();
            primeCalc = new PrimeCalc();
        }
        public void RunProgramm()
        {
            Console.WriteLine("#String Calculator#");

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "exit") break;
                DoCalc(ref input);
                Console.WriteLine("============================\nto stop enter \"exit\"");
            }
        }
        private void DoCalc(ref string input)
        {
            try
            {
                double res = calc.Calculate(input);
                Console.WriteLine(res);
                Console.WriteLine(primeCalc.IsPrime(res) ? "чило простое" : "число непростое");
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
