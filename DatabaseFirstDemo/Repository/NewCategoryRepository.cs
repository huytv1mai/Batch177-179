using DatabaseFirstDemo.DAO;
using DatabaseFirstDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstDemo.Repository
{
	public class NewCategoryRepository : INewCategoryRepository
	{
		public IEnumerable<NewCategory> GetAll() => NewCategoryDao.Instance.GetAll();
		public void Insert(NewCategory newCategory) => NewCategoryDao.Instance.Insert(newCategory);
		public void Update(NewCategory newCategory) => NewCategoryDao.Instance.Update(newCategory);
		public NewCategory GetById(int id) => NewCategoryDao.Instance.GetById(id);
		public void Delete(NewCategory newCategory) => NewCategoryDao.Instance.Delete(newCategory);
	}
}
