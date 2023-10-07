using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole
{
    internal class Bai8
    {
        public void Run()
        {
            int ValueA = 10;
            int ValueB = 20;
            int ValueC = 0;
            ValueC = ValueA++ + ValueB;//A=11
            Console.WriteLine("ValueC= "+ ValueC);//31 30
            ValueC = ++ValueA - ValueB;//A=12
            Console.WriteLine("ValueC= " + ValueC);//-9 -8
            ValueC = ++ValueA + ++ValueB;//A=13 B=21
            Console.WriteLine("ValueC= " + ValueC);//34 
            ValueC = --ValueA + ValueB--;//A=12 
            Console.WriteLine("ValueC= " + ValueC);//32 33
        }
    }
}
