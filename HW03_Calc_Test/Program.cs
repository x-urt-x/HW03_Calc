using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UINS;

namespace HW03_Calc_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ui = new UserInterface(new ConsoleIO());
            ui.RunProgramm();
        }
    }
}

