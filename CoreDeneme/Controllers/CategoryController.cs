using Microsoft.AspNetCore.Mvc;

namespace CoreDeneme.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
