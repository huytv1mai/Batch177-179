using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Session10
{
    internal class ExampleAnonymousMethod
    {
        public delegate void MyDelegate(int value1, int value2);
        public void Run()
        {
            MyDelegate myDele = delegate (int a, int b)
            {
                Console.WriteLine("Add: " + (a + b));
            };
            myDele += delegate (int a, int b)
            {
                Console.WriteLine("Sub: " + (a - b));
            };
            myDele += delegate
            {
                Console.WriteLine("This is Anonymous Method");
            };
            myDele(100, 85);
        }
    }
}
