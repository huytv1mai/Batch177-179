using DatabaseFirstDemo.Repository;
using Microsoft.AspNetCore.Mvc;

namespace WebDemo14112023.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NewsController : BaseController
    {
        INewsRepository newsRepository = null;
        public NewsController(NewsRepository _newsRepository)
        {
            newsRepository = _newsRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
