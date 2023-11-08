using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN.CollectionAndGenegle
{
    public class HashTableProgram
    {
        public void Run()
        {
            Hashtable daysOfWeek = new Hashtable();

            // Thêm các ngày trong tuần vào Hashtable với keys từ 1-7
            daysOfWeek.Add(1, "Monday");
            daysOfWeek.Add(2, "Tuesday");
            daysOfWeek.Add(3, "Wednesday");
            daysOfWeek.Add(4, "Thursday");
            daysOfWeek.Add(5, "Friday");
            daysOfWeek.Add(6, "Saturday");
            daysOfWeek.Add(7, "Sunday");

            // Tìm "Tuesday" và kiểm tra xem có tồn tại không
            string tuesday = (string)daysOfWeek[2]; // 2 là key của Tuesday
            if (tuesday != null)
            {
                Console.WriteLine($"Tuesday is found: {tuesday}");
            }
            else
            {
                Console.WriteLine("Tuesday is not found.");
            }

            // In ra toàn bộ ngày trong tuần (key và value)
            Console.WriteLine("Days of the week:");
            foreach (DictionaryEntry entry in daysOfWeek)
            {
                int key = (int)entry.Key;
                string value = (string)entry.Value;
                Console.WriteLine($"Key: {key}, Value: {value}");
            }
        }
    }
}
