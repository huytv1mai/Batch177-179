using DataAccessTestDMA.DAO;
using DataAccessTestDMA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTestDMA.Repository
{
    public class DoctorRepository : IDoctorRepository
    {
        public void DeleteDoctor(Doctor p) => DoctorDAO.DeleteDoctor(p);
        public void UpdateDoctor(Doctor p) => DoctorDAO.UpdateDoctor(p);
        public void SaveDoctor(Doctor p) => DoctorDAO.SaveDoctor(p);
        public List<Specialty> GetSpecialties() => SpecialtyDAO.GetSpecialties();
        public List<Doctor> GetDoctors() => DoctorDAO.GetDoctors();
        public Doctor GetDoctorById(int id) => DoctorDAO.FindDoctorByID(id);
    }
}
