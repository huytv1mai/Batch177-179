using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Session6
{
    public class Cat : Animal
    {
      
        private string color;//field must private
        /*public string GetColor() { return  color; }
        public void SetColor(string color)
        {
            this.color = color;
        }*/
        public string Color { get; set; }
        public int? Age { get; set; }
        public new void Eat()
        {
            base.Eat();
            Console.WriteLine("Cat Eat...");
        }
        public void Run()
        {
            Age = null;
        }
        /*   public void ToString()
           {
               //base keyword
               base.Eat();//Phương thức
               base.DoSomething();
           }*/
    }
}
