using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Lab4
{
    internal class Calculator<T>
    {
        public T Add(T a, T b)
        {
            dynamic operand1 = a;
            dynamic operand2 = b;
            return operand1 + operand2;
        }

        public T Subtract(T a, T b)
        {
            dynamic operand1 = a;
            dynamic operand2 = b;
            return operand1 - operand2;
        }

        public T Multiply(T a, T b)
        {
            dynamic operand1 = a;
            dynamic operand2 = b;
            return operand1 * operand2;
        }

        public T Divide(T a, T b)
        {
            dynamic operand1 = a;
            dynamic operand2 = b;
            return operand1 / operand2;
        }
    }

    class CaculatorDemo
    {
        public void Run()
        {
            //RunTime
            Calculator<int> intCalculator = new Calculator<int>();
            int intResult1 = intCalculator.Add(5, 3);
            int intResult2 = intCalculator.Subtract(10, 4);
            int intResult3 = intCalculator.Multiply(6, 2);
            int intResult4 = intCalculator.Divide(15, 5);
            Console.WriteLine($"Integer Results: {intResult1}, {intResult2}, {intResult3}, {intResult4}");

            Calculator<double> doubleCalculator = new Calculator<double>();
            double doubleResult1 = doubleCalculator.Add(5.5, 3.2);
            double doubleResult2 = doubleCalculator.Subtract(10.8, 4.3);
            double doubleResult3 = doubleCalculator.Multiply(6.2, 2.5);
            double doubleResult4 = doubleCalculator.Divide(15.6, 5.1);
            Console.WriteLine($"Double Results: {doubleResult1}, {doubleResult2}, {doubleResult3}, {doubleResult4}");
        }
    }

}
