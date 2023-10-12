using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.ClassAndMethod
{
    public class GiaiPhuongTrinh
    {
        public void Run()
        {
            double a, b, c;
            a = GetDouble("Nhap gia tri a: ");
            b = GetDouble("Nhap gia tri b: ");
            c = GetDouble("Nhap gia tri c: ");
            if (a == 0)
            {
                Console.WriteLine("Phuong trinh Bac mot:\n"+PhuongTrinh(b, c));
            }
            else
            {
                Console.WriteLine("Phuong trinh Bac hai: "+ PhuongTrinh(a,b,c));
            }
        }

        string PhuongTrinh(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;
            double x1, x2;
            if (delta > 0)
            {
                x1=(-b+Math.Sqrt(delta))/ (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return "PT co 2 nghiem: x1= " + x1 + " x2= " + x2;
            }
            else if (delta < 0)
            {
                return "PT vo nghiem";
            }
            else
            {
                return "PT nghiem kep x1=x2=" + -b / (2 * a);
            }
        }

        string PhuongTrinh(double a, double b)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    return "PT vo so nghiem";
                }
                else
                {
                    return "PT vo nghiem";
                }
            }
            else
            {
                return "PT co nghiem x=" + -b / a;
            }
        }

        double GetDouble(string mes)
        {
            Console.WriteLine(mes);
            double so = Convert.ToDouble(Console.ReadLine());
            return so;
        }
    }


}
