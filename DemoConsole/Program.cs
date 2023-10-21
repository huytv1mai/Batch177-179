using DemoConsole.Lab4;
using DemoConsole.Session11;
using DemoConsole.Session13;
using ABC = Automotive;
namespace DemoConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new CalculateRectangle().Run();
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

