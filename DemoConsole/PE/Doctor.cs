using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.PE
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specilization { get; set; }
        public (int id, string name, string specilation) GetDoctorInfo()
        {
            return (Id, Name, Specilization);
        }
    }

}
