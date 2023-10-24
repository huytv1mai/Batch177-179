using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.PE
{
    public class DoctorDemo
    {
        public static void Main(string[] args)
        {
            //Question 1.1:

            /*Doctor doctor = new Doctor()
            {
                Id = 1,Name="Nguyen Van Smith", Specilization= "Cardiology"
            };*/

            //Question 1.2:
            List<Doctor> list = new List<Doctor>() { 
                new Doctor { Id=1, Name="Nguyen Van Smith", Specilization="Cardiology"} ,
                new Doctor { Id=2, Name="Tran Van David", Specilization="Cardiology"} ,
                new Doctor { Id=3, Name="Hoang Thi Lion", Specilization="Pediatrics"} ,
                new Doctor { Id=4, Name="Le Van John", Specilization="Cardiology"} ,
                new Doctor { Id=5, Name="Ly Dieu Smith", Specilization="Pediatrics"} ,
            };
            //Question 1.3:
            foreach (var item in list)
            {
                var doctorInfo = item.GetDoctorInfo();
                Console.WriteLine($"{doctorInfo.id}-{doctorInfo.name}-{doctorInfo.specilation}");
            }
            //Question 2.1:
            var doctorSpecilization = list.Where(p => p.Specilization == "Cardiology");
            Console.WriteLine("1.\tFilter doctors specializing in \"Cardiology\":");
            foreach (var item in doctorSpecilization)
            {
                Console.WriteLine($"{item.Id,3}-{item.Name,20}-{item.Specilization,15}");
            }
            //Question 2.2:
            var doctorName = list.Where(p => p.Name.Contains("Smith"));
            Console.WriteLine("2.\tFind doctors whose names contain the keyword \"Smith\":");
            foreach (var item in doctorName)
            {
                Console.WriteLine($"{item.Id,3}-{item.Name,20}-{item.Specilization,15}");
            }
            //Question 2.3:
            var doctorOrderById = list.OrderByDescending(p => p.Id);
            Console.WriteLine("3.\tSort the doctor list in descending order by DoctorID:");
            foreach (var item in doctorOrderById)
            {
                Console.WriteLine($"{item.Id,3}-{item.Name,20}-{item.Specilization,15}");
            }
            //Question 2.4:
            Doctor newDoctor = new Doctor()
            {
                Id=6,Name="John Doe",Specilization= "Pediatrics"
            };
            list.Add(newDoctor);
            //Question 2.5:
            Console.WriteLine("5.\tPrint the doctor list after performing the above operations");
            foreach (var item in list)
            {
                var doctorInfo = item.GetDoctorInfo();
                Console.WriteLine($"{doctorInfo.id}-{doctorInfo.name}-{doctorInfo.specilation}");
            }
            //Question 3.1:
            var doctorIdGreater = list.Where(p => p.Id>3);
            Console.WriteLine("1.\tUse LINQ to find and print the names of doctors who have a DoctorID greater than 3:");
            foreach (var item in doctorIdGreater)
            {
                Console.WriteLine($"{item.Id,3}-{item.Name,20}-{item.Specilization,15}");
            }
            //Question 3.2:
            double doctorAverate = list.Average(p => p.Id);
            Console.WriteLine("2.\tUse LINQ to calculate the average DoctorID of all doctors in the list:");
            Console.WriteLine($"Average: {doctorAverate,5}");
            //Question 3.3:
            int doctorCount = list.Count(p => p.Specilization  == "Pediatrics");
            Console.WriteLine("3.\tUse LINQ to count the number of doctors specializing in \"Pediatrics\":");
            Console.WriteLine($"Count by \"Pediatrics\": {doctorCount,5}");
            //Question 3.4:
            var doctorGroupDoctor = list.GroupBy(p => p.Specilization)
                .Select(g=> new { Specilization = g.Key, Count=g.Count() });
            Console.WriteLine("4.\tUse LINQ to group doctors by their Specialization and print the count of doctors in each specialization group:");
            foreach (var item in doctorGroupDoctor)
            {
                Console.WriteLine($"{item.Specilization,15}-{item.Count,5}");
            }
        }
    }
}
