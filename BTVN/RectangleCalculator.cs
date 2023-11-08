using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN
{
    public class RectangleCalculator
    {
        public delegate double RectangleDelegate(double wight, double hight);
        public double CalculatePerimeter(double wight, double hight)
        {
            return 2* (wight + hight);
        }
        public double CalculateArea(double wight, double hight)
        {
            return (wight * hight);
        }
    }
}
