using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Operators
{
    internal class Bai11
    {
        public void Run()
        {
            int a = GetInt("Please enter a: ");
            int b = GetInt("Please enter b: ");
            while (true)
            {
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Sub");
                Console.WriteLine("3. Mul");
                Console.WriteLine("4. Div");
                int num = GetInt("Please enter a number: ");
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Add: " + Add(a, b));
                        break;
                    case 2:
                        Console.WriteLine("Sub: " + Sub(a, b));
                        break;
                    case 3:
                        Console.WriteLine("Mul: " + Mul(a, b));
                        break;
                    case 4:
                        Div(a, b);
                        break;
                    default:
                        Console.WriteLine("You enter fail!");
                        break;
                }
            }
        }

        public int Add(int a, int b) => a + b;
        public int Sub(int a, int b) => a - b;
        public int Mul(int a, int b) => a * b;

        public void Div(int a, int b)
        {
            Console.WriteLine("Do you want to calculate the quotient or remainder?");
            Console.WriteLine("(1) Quotient");
            Console.WriteLine("(2) Remainder");
            int n = GetInt("Please enter a number to choice: ");
            switch (n)
            {
                case 1:
                    Console.WriteLine("a/b: " + a / b);
                    break;
                case 2:
                    Console.WriteLine("a%b: " + a % b);
                    break;
                default: break;
            }
        }
        public int GetInt(string mess)
        {
            Console.WriteLine(mess);
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }

        public double GetDoube(string mess)
        {
            Console.WriteLine(mess);
            double num = Convert.ToDouble(Console.ReadLine());
            return num;
        }
    }
}
