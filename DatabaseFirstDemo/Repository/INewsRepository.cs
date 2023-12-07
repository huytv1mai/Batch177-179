using DatabaseFirstDemo.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstDemo.Repository
{
    public interface INewsRepository
    {
        IEnumerable<News> GetAll();
        void Insert(News news);
        void Update(News news);
        News GetById(int id);
        void Delete(News news); 
        IEnumerable<NewCategory> GetAllNewCategory();
        bool ChangeStatus(int id);
        List<News> GetNewsByKeyword(string keyword, string sortBy, int? categoryId);
    }
}
