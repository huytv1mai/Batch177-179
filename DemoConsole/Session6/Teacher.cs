using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Session6
{
    interface IPerson
    {
        void Running();
    }

    interface IMother
    {
        void Sound();
    }

    public class Teacher: IPerson, IMother
    {
        public void Sound()
        {
            Console.WriteLine("Oa oa...");
        }
        public void Running()
        {
            Console.WriteLine("Running...");
        }
    }
}
