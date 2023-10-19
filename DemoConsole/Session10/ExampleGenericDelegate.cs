using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Session10
{
    internal class ExampleGenericDelegate
    {
        //public int Add(int a, int b) => a + b;
        public int Sub(int a, int b) => a - b;
        public void Print(string msg) => Console.WriteLine(msg);
        public void Run()
        {
            int a = 100, b = 85, add, sub;
            string strResult;
            //Generic Delegate Fuction (allow return), not have ref and out parameter
            Func<int, int, int> AddFuc = ((a, b) => a + b); //Add;
            add = AddFuc(a, b);
            Func<int, int, int> SubFuc = Sub;
            sub = SubFuc(a, b);
            strResult = $"Add: {add,5}, Sub: {sub,5}";
            //Generic Delegate Action
            Action<string> action = Print;
            action(strResult);
        }
    }
}
