using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BTVN
{
    public class BTVN_2
    {
        public void SolveEqua2(double a, double b, double c)
        {
            Console.WriteLine("câu 1");
            double delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"PhuongTrinhCo2nghiem: x1= {x1}, x2 ={x2}");
            }
            else if (delta == 0)
            {
                double x = -b/(2*a);
                Console.WriteLine($"PhuongTrinhConghiemkep: x= {x}");
            }    
            else
            { Console.WriteLine("Phương trình không có nghiệm thực"); }    

        }
        public void CalculateSum2Fraction(int a, int b, int c, int d)
        {
            Console.WriteLine("câu 2");
            int tongtuso = a * d + b * c;
            int tongmauso = b * d;
            int hieutuso = a * d - b * c;
            int hieumauso = b * d;
            double tongphanso = (double)tongtuso / tongmauso;
            double hieuphanso = (double)hieutuso / hieumauso;
            Console.WriteLine($"Tong Phan So:{tongphanso}");
            Console.WriteLine($"Hieu Phan So:{hieuphanso}");

        }
    }
}
