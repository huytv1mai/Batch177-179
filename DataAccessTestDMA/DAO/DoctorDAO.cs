using DataAccessTestDMA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTestDMA.DAO
{
    public class DoctorDAO
    {
        public static List<Doctor> GetDoctors()
        { var listDoctors = new List<Doctor>();
            try 
            {
                using (var context = new TestDmaContext())
                {
                    listDoctors = context.Doctors.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listDoctors;
         }
        public static Doctor FindDoctorByID(int proId)
        {
            Doctor p = new Doctor();
            try
            {
                using (var context = new TestDmaContext())
                {
                    p = context.Doctors.SingleOrDefault(x => x.DoctorId == proId);
                }
            }
            catch (Exception e)
            { throw new Exception(e.Message); }
            return p;
        }
        public static void SaveDoctor(Doctor p)
        {
            try
            {
                using (var context = new TestDmaContext())
                {
                    context.Doctors.Add(p);
                    context.SaveChanges();
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void UpdateDoctor(Doctor p)
        {
            try
            {
                using (var context = new TestDmaContext())
                {
                    context.Entry<Doctor>(p).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void DeleteDoctor(Doctor p)
        {
            try
            {
                using (var context = new TestDmaContext())
                {
                    var p1 = context.Doctors.SingleOrDefault(c => c.DoctorId == p.DoctorId);
                    context.Doctors.Remove(p1);
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
