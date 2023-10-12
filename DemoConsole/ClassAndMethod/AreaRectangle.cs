using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.ClassAndMethod
{
    public class AreaRectangle
    {
        private double length;
        private double width;
        public AreaRectangle() { }
        public AreaRectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        private double Area()
        {
            return length*width;
        }

        public void Run()
        {
            Console.WriteLine("Area: "+ Area());

        }
    }
}
