using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.ClassAndMethod
{
    public class StudentInfo
    {
        private int id;
        private string name;
        private int age;
        private string address;
        public StudentInfo(int id, string name, int age, string address)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.address = address;
        }
        public string ToString()
        {
            return $"{id,3} - {name, 10} - {age,3} - {address, 15}";
        }
    }
}
