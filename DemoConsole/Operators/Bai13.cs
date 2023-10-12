using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Operators
{
    public class Bai13
    {
        public void Run()
        {
            int num = 1;
            Console.WriteLine("List of Event Numbers");
            do
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("{0} is even number", num);
                }
                num++;
            } while (num <= 11);
        }
    }
}
