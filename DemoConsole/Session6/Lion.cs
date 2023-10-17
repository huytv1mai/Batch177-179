using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Session6
{
    public abstract class Animal2
    {
        public abstract int Id { get; set; }
        public void Eat()
        {
            Console.WriteLine("Animal Eat...");
        }
        public abstract void AnimalSound();
        public abstract void Running();
    }
    public class Lion : Animal2
    {
        public override int Id { get; set; }
        public override void Running()
        {
            Console.WriteLine("Running...");
        }
        public override void AnimalSound()
        {
            Lion a = new Lion();
            a.Id = 10;
            Console.WriteLine("Hello: "+ a.Id);
        }
    }
}
