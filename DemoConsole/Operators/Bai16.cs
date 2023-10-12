using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Operators
{
    public class Bai16
    {
        public void Run()
        {
            Console.WriteLine("Please enter number of element: ");
            int n = Convert.ToInt32(Console.ReadLine());
            //Initial Array
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = new Random().Next(10);
            }
            Console.WriteLine("List: ");
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[j] + " ");
            }
        }
    }
}
