using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Session6
{
    class Employees
    {
        int _empId = 1;
        string _empName = "James Anderson";
        int _age = 25;
        public void Display()
        {
            Console.WriteLine("Employee ID:" + _empId);
            Console.WriteLine("Employee Name:" + _empName);
        }
    }
    class Department : Employees
    {
        int _deptId = 501;
        string _deptName = "Sales";
        /// <summary>
        /// Contructor
        /// </summary>
        public Department() { }
        public Department(int depId)
        {
            this._deptId = depId;
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine("Department ID:" + _deptId);
            Console.WriteLine("Department Name:" + _deptName);
        }
        /* static void Main(string[] args)
         {
             Department objDepartment = new Department();
             objDepartment.Display();
         }*/
    }
}
