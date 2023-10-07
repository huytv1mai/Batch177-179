using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole
{
    internal class Bai5
    {
        public void Run()
        {
            int valueOne = 10;
            int valueTwo = 2;
            int add = valueOne + valueTwo;
            int sub = valueOne - valueTwo;
            int mult = valueOne * valueTwo;
            int div = valueOne / valueTwo;
            int modu = valueOne % valueTwo;
            Console.WriteLine("Addition " + add);
            Console.WriteLine("Subtraction " + sub); 
            Console.WriteLine("Multiplication " + mult); 
            Console.WriteLine("Division " + div);
            Console.WriteLine("Remainder " + modu);

        }
    }
}
