using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Lab4
{
    internal class HashTableDemo
    {
        public void Run()
        {
            // Create a Hashtable to store days of the week
            Hashtable daysOfWeek = new Hashtable();

            // Add days of the week with keys from 1 to 7
            daysOfWeek.Add(1, "Monday");
            daysOfWeek.Add(2, "Tuesday");
            daysOfWeek.Add(3, "Wednesday");
            daysOfWeek.Add(4, "Thursday");
            daysOfWeek.Add(5, "Friday");
            daysOfWeek.Add(6, "Saturday");
            daysOfWeek.Add(7, "Sunday");

            // Find Tuesday and print a message if found or not
            if (daysOfWeek.ContainsValue("Tuesday"))
            {
                Console.WriteLine("Tuesday is found in the hashtable.");
            }
            else
            {
                Console.WriteLine("Tuesday is not found in the hashtable.");
            }

            // Print out the days of the week with both key and value
            foreach (DictionaryEntry entry in daysOfWeek)
            {
                Console.WriteLine("Key: {0}, Value: {1}", entry.Key, entry.Value);
            }
        }
    }
}
