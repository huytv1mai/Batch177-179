using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Session13
{
    internal class CalculateRectangle
    {
        (double perimeter, double area, double smallerSideLength) CalculateRectangleProperties(double width, double height)
        {
            double perimeter = (width + height) * 2;
            double area = width * height;
            double smallerSideLength = (width >= height ? height : width);
            return (perimeter, area, smallerSideLength);
        }

        public void Run()
        {
            double width,height;
            width = GetDouble("Please input width of Rectangle: ");
            height = GetDouble("Please input height of Rectangle: ");
            var result = CalculateRectangleProperties(width, height);
            Console.WriteLine($"Perimeter: {result.perimeter}, Area: {result.area}, Smaller Side Length: {result.smallerSideLength}");
        }

        double GetDouble(string msg)
        {
            Console.WriteLine(msg);
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
