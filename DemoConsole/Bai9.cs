using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole
{
    internal class Bai9
    {
        public void Run()
        {
            int valueOne = 5; 
            int valueTwo = 10;
            Console.WriteLine("Value1 =" + valueOne);
            valueOne += 4;
            Console.WriteLine("Value1 += 4= " + valueOne);
            valueOne -= 8;
            Console.WriteLine("Value1 -= 8= " + valueOne); 
            valueOne *= 7;
            Console.WriteLine("Value1 *= 7= " + valueOne);
            valueOne /= 2;
            Console.WriteLine("Value1 /= 2= " + valueOne);
            Console.WriteLine("Value1 == Value2: {0}", (valueOne == valueTwo));

        }
    }
}
