using DataAccessTestDMA.DAO;
using DataAccessTestDMA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTestDMA.Repository
{
    public class SpecialtyRepository : ISpecialtyRepository
    {
        public List<Specialty> GetSpecialties() => SpecialtyDAO.GetSpecialties();
        public Specialty GetSpecialtyById(int id) => SpecialtyDAO.FindSpecialtyById(id);
        public void SaveSpecialty(Specialty specialty) => SpecialtyDAO.SaveSpecialty(specialty);
        public void UpdateSpecialty(Specialty specialty) => SpecialtyDAO.UpdateSpecialty(specialty);
        public void DeleteSpecialty(Specialty specialty) => SpecialtyDAO.DeleteSpecialty(specialty);
    }
}
