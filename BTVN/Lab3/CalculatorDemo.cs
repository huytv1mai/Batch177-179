using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN.CollectionAndGenegle
{
    using System;

    public class Calculator<T>
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
            if (operand2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return operand1 / operand2;
        }
    }
    class CalculatorDemo
    {
        public void Run()
        {
            Calculator<int> intCalculator = new Calculator<int>();
            Console.WriteLine("Addition: " + intCalculator.Add(5, 3));
            Console.WriteLine("Subtraction: " + intCalculator.Subtract(10, 4));
            Console.WriteLine("Multiplication: " + intCalculator.Multiply(6, 7));
            Console.WriteLine("Division: " + intCalculator.Divide(15, 3));

            Calculator<double> doubleCalculator = new Calculator<double>();
            Console.WriteLine("Addition: " + doubleCalculator.Add(5.5, 3.2));
            Console.WriteLine("Subtraction: " + doubleCalculator.Subtract(10.3, 4.1));
            Console.WriteLine("Multiplication: " + doubleCalculator.Multiply(6.4, 7.8));
            Console.WriteLine("Division: " + doubleCalculator.Divide(15.0, 3.0));
        }
    }
}
