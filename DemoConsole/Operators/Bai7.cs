using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Operators
{
    internal class Bai7
    {
        public void Run()
        {
            int num = 0;
            if (num >= 1 && num <= 10)
            {
                Console.WriteLine("The number exists between 1 and 10");
            }
            else
            {
                Console.WriteLine("The number does not exist between 1 and 10");
            }
            num = -5;
            if (num < 0 || num > 10)
            {
                Console.WriteLine("The number does not exist between 1 and 10");
            }
            else
            {
                Console.WriteLine("The number exists between 1 and 10");
            }

        }
    }
}
