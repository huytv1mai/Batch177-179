using DatabaseFirstDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstDemo.Repository
{
	public interface INewCategoryRepository
	{
		IEnumerable<NewCategory> GetAll();
		void Insert(NewCategory role);
		void Update(NewCategory role);
		NewCategory GetById(int id);
		void Delete(NewCategory role);
	}
}
