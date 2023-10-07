using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole
{
    public class Bai3
    {
        public void Run()
        {
            string userName;
            Console.WriteLine("Moi nhap ten: ");//Output
            userName = Console.ReadLine();
            Console.WriteLine("Moi nhap tuoi: ");//Output
            int a= Convert.ToInt32(Console.ReadLine());//Input
            Console.WriteLine("Moi nhap luong: ");//Output
            double b = Convert.ToDouble(Console.ReadLine());//Input
            Console.WriteLine("Name: {0} - age: {1} - salary: {2}",userName, a,b);//Output
            Console.ReadLine();//Chờ nhấn phím
        }
    }
}
