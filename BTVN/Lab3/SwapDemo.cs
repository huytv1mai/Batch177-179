using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN.CollectionAndGenegle
{
    class SwapUtils
    {
        public void Swap<T>(T[] array, int index1, int index2)
        {
            if (index1 < 0 || index1>= array.Length || index2 < 0 || index2 >= array.Length)
            {
                throw new ArgumentException("Invalid index");
            }    
            T temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }    
    }
    internal class SwapDemo
    {
        public void Run()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Before Swap: " + string.Join(", ", numbers));
            SwapUtils s = new SwapUtils();
            s.Swap(numbers, 1, 3);
            Console.WriteLine("After Swap: "+ string.Join(", ", numbers));
            string[] names = { "Huy", "Vân", "Mai" };
            Console.WriteLine("Before Swap: " + string.Join(", ", names));
            s.Swap(names, 0, 2);
            Console.WriteLine("After Swap: " + string.Join(", ", names));
        }
    }
}
