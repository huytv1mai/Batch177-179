using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Operators
{
    public class Bai17
    {
        public void Run()
        {
            string[] days = new string[7];
            days[0] = "Sunday";
            days[1] = "Monday";
            days[2] = "Tuesday";
            days[3] = "Wednesday";
            days[4] = "Thursday";
            days[5] = "Friday";
            days[6] = "Saturday";
            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i]);
            }
        /*while (true)
        {*/
        nhan:
            Console.WriteLine("Please enter a keyword: ");
            string keyword = Console.ReadLine();
            if (keyword == "0") { goto ends; }
            for (int i = 0; i < days.Length; i++)
            {
                if (keyword.Contains(days[i]))
                {
                    Console.WriteLine(days[i]);
                }
            }
            goto nhan;

        ends:
            Console.ReadLine();
            /*}*/
        }
    }
}
