using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN
{
    public class BTVN_1
    {
        public void Run()
        {
            // Câu 1
            Console.WriteLine("câu 1");
            int n = 5; // Số lượng dấu sao ban đầu
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(); // Thêm dấu cách giữa các nhóm dấu sao
            }
            Console.WriteLine(); // Xuống dòng sau khi hoàn thành câu 1

            // Câu 2 - Bảng Cửu Chương
            Console.WriteLine("câu 2");
            Console.WriteLine("\nBảng Cửu Chương:");
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int result = i * j;
                    Console.Write($"{i} x {j} = {result}\t");
                }
                Console.WriteLine(); // Xuống dòng sau khi hoàn thành một bảng cửu chương
            }
            Console.ReadKey();
        }
    }
}
