using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Operators
{
    internal class Bai10
    {
        public void Run()
        {
            int num = 13;
            if (num < 0)
            {
                Console.WriteLine("The number is Negative");
            }
            else if (num % 2 == 0)
            {
                Console.WriteLine("The number is Even");
            }
            else
            {
                Console.WriteLine("The number {0} is odd", num);
            }
        }
    }
}
