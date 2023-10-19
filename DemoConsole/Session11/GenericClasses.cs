using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Session11
{
    class MyClass<T>
    {
        public T Data { get; set; }
        public override string ToString()
        {
            return $"Data: {Data}";
        }
    }
    internal class GenericClasses
    {
        public void Run()
        {
            MyClass<string> myClass = new MyClass<string> { Data = "Hello World" }; 
            Console.WriteLine(myClass);
            MyClass<float> myClass2 = new MyClass<float> { Data = 5.6f };
            Console.WriteLine(myClass2);
            dynamic obj = new { Id = 1, Name = "David" };
            MyClass<dynamic> myClass3 = new MyClass<dynamic> { Data = obj };
            Console.WriteLine(myClass3);
        }
    }
}
