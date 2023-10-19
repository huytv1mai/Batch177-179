using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Session10
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public override string ToString()
        {
            return $"Id: {Id,3} - Name: {Name,20} - Address: {Address,10}";
        }
    }
    internal class LambdaExpression
    {
        public void Run()
        {
            List<Student> list = new List<Student>
            {
                new Student{ Id=1, Name="Nguyen Van An", Address="Da Nang"},
                new Student{ Id=2, Name="Tran Thi Be",Address="An Giang"},
                new Student{ Id=3, Name="Hoang Ba Thong", Address="Quang Nam"},
                new Student{ Id=4, Name="Cai Thi Kieu",Address="Hue"},
                new Student{ Id=5, Name="Khong Tuoc Quynh",Address="Da Nang"},
            };
            foreach (var name in list.OrderBy(s => s.Address))
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Please enter keyword to search: ");
            string keywork = Console.ReadLine();
            var list_search = list.FirstOrDefault(s => s.Name.Contains(keywork));
            if (list_search != null)
            {
                Console.Write($"Result: {list_search}");
            }
            else
            {
                Console.WriteLine("Not found!");
            }
        }
    }
}
