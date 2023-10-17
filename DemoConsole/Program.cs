using DemoConsole.ClassAndMethod;
using DemoConsole.Operators;
using DemoConsole.Session6;
using DemoConsole.Session8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            University.UniversityName = "FPT University";
            University.Department = "CF";
            Console.WriteLine($"School {University.UniversityName} - {University.Department}");
        }
    }

}
