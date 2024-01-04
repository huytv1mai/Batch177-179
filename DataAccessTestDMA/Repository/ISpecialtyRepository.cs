using DataAccessTestDMA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTestDMA.Repository
{
    public interface ISpecialtyRepository
    {
        List<Specialty> GetSpecialties();
        Specialty GetSpecialtyById(int id);
        void SaveSpecialty(Specialty specialty);
        void UpdateSpecialty(Specialty specialty);
        void DeleteSpecialty(Specialty specialty);
    }
}
