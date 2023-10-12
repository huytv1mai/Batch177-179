using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.ClassAndMethod
{
    public class RefAndOut
    {
        void Swap(ref int a, out int b)
        {
            b = 5;
            int tmp;
            tmp = a;
            a = b;
            b = tmp;
        }
        public void Run()
        {
            int a=3; int b;
            Swap(ref a, out b);
            Console.WriteLine("a: {0}, b{1}", a, b);
        }
    }
}
