using DatabaseFirstDemo.Models;
using X.PagedList;

namespace WebDemo14112023.Areas.Admin.Models
{
    public class NewCategoryUsers
    {
        public ICollection<NewCategory> NewCategory { get; set; }
        public IPagedList<News> News { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
