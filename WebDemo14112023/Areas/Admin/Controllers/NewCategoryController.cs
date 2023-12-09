using DatabaseFirstDemo.Models;
using DatabaseFirstDemo.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebDemo14112023.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    [Authorize(AuthenticationSchemes = "Admin")]
    public class NewCategoryController : BaseController
    {
        INewCategoryRepository newCategoryRepository = null;
        public NewCategoryController()
        {

            newCategoryRepository = new NewCategoryRepository();
        }

        public IActionResult Index()
        {

            /*ProductMangementBatch177Context _context = new ProductMangementBatch177Context();
            var list = _context.NewsCategories.ToList();*/
            var result = newCategoryRepository.GetAll();
            return View(result);
        }

        // GET: Admin/Roles/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Create(NewCategory newCategory)
        {
            try
            {
                /*         if (ModelState.IsValid)
                         {*/
                newCategoryRepository.Insert(newCategory);
                SetAlert("Insert Data is success!", "success");
                return Json(new { success = true });
                /*}*/
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
            return Json(new { success = false });
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            NewCategory newCategory = newCategoryRepository.GetById(id);
            var data = new
            {
                Id = newCategory.Id,
                Name = newCategory.CategoryName
                // Các trường khác
            };

            return new JsonResult(new { success = true, data = data });
        }

        [HttpPost]
        public JsonResult Edit(NewCategory newCategory)
        {
            try
            {
                /*  if (ModelState.IsValid)
                  {*/
                newCategoryRepository.Update(newCategory);
                SetAlert("Update Data is success!", "success");
                /*}*/
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
            return Json(new { success = true });
        }

        [HttpPost]
        public JsonResult Delete(NewCategory newCategory)
        {
            try
            {
                newCategoryRepository.Delete(newCategory);
                SetAlert("Delete Data is success!", "success");

            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
            return Json(new { success = true });
        }

    }
}
