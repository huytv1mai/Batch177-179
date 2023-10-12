using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Operators
{
    public class Bai15
    {
        public void Run()
        {
            int rows = 2; int columns = 2;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("{0,5}", i * j);
                }
                Console.WriteLine();
            }

        }
    }
}
