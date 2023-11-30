using DatabaseFirstDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstDemo.DAO
{
    public class NewCategoryDao
    {
        private static NewCategoryDao instance;
        private static readonly object instanceLock = new object();
        public static NewCategoryDao Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new NewCategoryDao();
                    }
                    return instance;
                }
            }
        }

        public List<NewCategory> GetAll()
        {
            List<NewCategory> NewCategory;
            try
            {
                using ProductManagermentBatch177Context stock = new ProductManagermentBatch177Context();
                NewCategory = stock.NewsCategories.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return NewCategory;
        }

        public NewCategory GetById(int? id)
        {
            NewCategory NewCategory;
            try
            {
                using ProductManagermentBatch177Context stock = new ProductManagermentBatch177Context();
                NewCategory = stock.NewsCategories.SingleOrDefault(r => r.Id == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return NewCategory;
        }

        public void Insert(NewCategory NewCategory)
        {
            try
            {
                using ProductManagermentBatch177Context stock = new ProductManagermentBatch177Context();
                stock.Add(NewCategory);
                stock.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(NewCategory NewCategory)
        {
            try
            {
                using ProductManagermentBatch177Context stock = new ProductManagermentBatch177Context();
                stock.Entry<NewCategory>(NewCategory).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                stock.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(NewCategory NewCategory)
        {
            try
            {
                using ProductManagermentBatch177Context stock = new ProductManagermentBatch177Context();
                var rl = stock.NewsCategories.SingleOrDefault(c => c.Id == NewCategory.Id);
                stock.Remove(rl);
                stock.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
