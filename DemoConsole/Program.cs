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
            /*var member = new Member() { Id = 1, Name = "An" };
            Console.WriteLine("Id: "+ member.Id+ ", Name: " + member.Name);*/
            new Bai17().Run();
        }
    }

    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
