using DataAccessTestDMA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTestDMA.Repository
{
    public interface IDoctorRepository
    {
        void SaveDoctor(Doctor p);
        Doctor GetDoctorById(int id);
        void DeleteDoctor(Doctor p);
        void UpdateDoctor(Doctor p);
        List<Specialty> GetSpecialties();
        List<Doctor> GetDoctors();
    }
}
