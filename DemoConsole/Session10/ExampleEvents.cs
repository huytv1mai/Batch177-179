using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Session10
{
    internal class ExampleEvents
    {
        public delegate void MyDelegate(string msg);
        event MyDelegate Print;
        public void Show(string msg) => Console.WriteLine(msg);
        public void Run()
        {
            Print += new MyDelegate(Show);
            Print("Hello World!");
        }
    }
}
