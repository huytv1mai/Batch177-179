using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole
{
    public class Bai14
    {
        public void Run()
        {
            for(int num = 1; num <= 11; num++)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("{0,5} is even number", num);
                }
            }
        }
    }
}
