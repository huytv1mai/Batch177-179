using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Session8
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }
        public override string ToString()
        {
            return $"Id: {Id}-{Name}-{Salary}";
        }
    }
    public class SalaryDetail:Employee
    {
        public void Run()
        {
            SalaryDetail salaryDetail = new SalaryDetail()
            {
                Id = 1,
                Name = "An",
                Salary = 15.567f
            };
            Console.WriteLine(salaryDetail.ToString());
        }
    }
}
