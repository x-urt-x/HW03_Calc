using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringCalculatorNS;
using PrimeCalcNS;
using IInOutPutNS;

namespace UINS
{
    public class UserInterface
    {
        StringCalculator calc;
        PrimeCalc primeCalc;
        private IInOutPut io;
        public UserInterface(IInOutPut setIO)
        {
            calc = new StringCalculator();
            primeCalc = new PrimeCalc();
            io = setIO;
        }
        public void RunProgramm()
        {
            io.WriteLine("#String Calculator#");

            while (true)
            {
                string input = io.ReadLine();
                if (input == "exit") break;
                DoCalc(ref input);
                io.WriteLine("============================\nto stop enter \"exit\"");
            }
        }
        private void DoCalc(ref string input)
        {
            try
            {
                double res = calc.Calculate(input);
                io.WriteLine(res.ToString());
                io.WriteLine(primeCalc.IsPrime(res) ? "чило простое" : "число непростое");
            }
            catch (CalcException e)
            {
                io.WriteLine("ошибка при вводе данных: " + e.Message);
            }
            catch (Exception e)
            {
                io.WriteLine("при работе программы возникло исключение: " + e.Message);
            }

        }
    }

    public class ConsoleIO : IInOutPut
    {
        string IInOutPut.ReadLine()
        {
            return Console.ReadLine();
        }

        void IInOutPut.WriteLine(string a)
        {
            Console.WriteLine(a);
        }
    }
}

