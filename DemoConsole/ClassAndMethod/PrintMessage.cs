using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.ClassAndMethod
{
    public class PrintMessage
    {
        public void Print(string mess)
        {
            Console.WriteLine(mess);
        }

        public void Run()
        {
            string notication = "Hello World!";
            //Cách 1
            Print(notication);
            //Cách 2
            PrintMessage print = new PrintMessage();
            print.Print(notication);
        }
    }
}
