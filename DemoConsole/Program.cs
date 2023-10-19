using DemoConsole.Session10;

using ABC = Automotive;
namespace DemoConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new ExampleMulticaseDelegate().Run();
        }
    }

}

namespace Automotive
{
    public class SpareParts { 
        string _spareName; 
        public SpareParts() { _spareName = "Gear Box"; } 
        public void Display() { 
            Console.WriteLine("Spare Part name: " + _spareName); 
        } 
    }
}

