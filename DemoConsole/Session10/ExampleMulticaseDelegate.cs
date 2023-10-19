using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Session10
{
    public delegate void MyDelegate(string msg);
    class MyClass
    {
        public void Print(string msg)
        {
            Console.WriteLine(msg.ToUpper());
        }

        public void Show(string msg)
        {
            Console.WriteLine(msg.ToLower());
        }

        public void Display(string msg)
        {
            Console.WriteLine(msg);
        }
    }
    public class ExampleMulticaseDelegate
    {
        MyClass myClass = new MyClass();
        public void Run()
        {
            string msg = "Multicase Delegate";
            MyDelegate objDelegate1 = myClass.Print;
            MyDelegate objDelegate2 = myClass.Show;
            Console.WriteLine("***Combine between objDelegate1 and objDelegate2***");
            MyDelegate myDelegate = objDelegate1+objDelegate2;
            myDelegate(msg);
            MyDelegate objDelegate3 = myClass.Display;
            myDelegate += objDelegate3;  
            Console.WriteLine("***Combine between objDelegate1, objDelegate2 and objDelegate3***");
            myDelegate(msg);
            myDelegate -= objDelegate2;
            Console.WriteLine("***Remove objDelegate2***");
            myDelegate(msg);
        }
    }
}
