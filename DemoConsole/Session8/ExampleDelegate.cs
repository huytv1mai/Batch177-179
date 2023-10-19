using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Session8
{
    //Create Delegate
    public delegate int MyDelegate(int num1, int num2);
    public delegate void MyDelegate2(string msg);
    class MyClass
    {
        public void PrintUpper(string mes) => Console.WriteLine(mes.ToUpper());
        public void PrintLower(string mes) => Console.WriteLine(mes.ToLower());
    }
    internal class ExampleDelegate
    {
        private void InVokeDelegate(MyDelegate2 dele, string msg) => dele(msg);
        private int Add(int num1, int num2) => num1 + num2;
        private int Sub(int num1, int num2) => num1 - num2;
        public void Run()
        {
            int a=10,b=20;
            int result;
            //Set target method
            MyDelegate obj1 = new MyDelegate(Add);
            //Invoke method
            result = obj1(a, b);
            Console.WriteLine($"{a}+{b}={result}");
            //
            string msg = "This is a message";
            MyClass obj2 = new MyClass();
            InVokeDelegate(obj2.PrintUpper,msg);
            InVokeDelegate(obj2.PrintLower, msg);
        }
    }
}
