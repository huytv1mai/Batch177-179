using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Session8
{
    internal class DivisionError
    {
        public void Run()
        {
            int numOne = 133;
            int numTwo = 0;
            int result;
            try
            {
                result = numOne / numTwo;
            }
            catch (Exception objDivide)
            {
                Console.WriteLine("Exceptioncaught:" + objDivide.ToString());
            }
        }
    }
}
