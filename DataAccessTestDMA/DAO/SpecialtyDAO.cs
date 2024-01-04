using DataAccessTestDMA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTestDMA.DAO
{
    public class SpecialtyDAO
    {
        public static List<Specialty> GetSpecialties()
        {
            var listSpecialties = new List<Specialty>();
            try
            {
                using (var context = new TestDmaContext())
                {
                    listSpecialties = context.Specialties.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listSpecialties;
        }

        public static Specialty FindSpecialtyById(int specialtyId)
        {
            Specialty specialty = new Specialty();
            try
            {
                using (var context = new TestDmaContext())
                {
                    specialty = context.Specialties.SingleOrDefault(x => x.SpecialtyId == specialtyId);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return specialty;
        }

        public static void SaveSpecialty(Specialty specialty)
        {
            try
            {
                using (var context = new TestDmaContext())
                {
                    context.Specialties.Add(specialty);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void UpdateSpecialty(Specialty specialty)
        {
            try
            {
                using (var context = new TestDmaContext())
                {
                    context.Entry<Specialty>(specialty).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void DeleteSpecialty(Specialty specialty)
        {
            try
            {
                using (var context = new TestDmaContext())
                {
                    var specialtyToDelete = context.Specialties.SingleOrDefault(c => c.SpecialtyId == specialty.SpecialtyId);
                    context.Specialties.Remove(specialtyToDelete);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
