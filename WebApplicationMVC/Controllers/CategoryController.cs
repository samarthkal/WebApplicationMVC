using Microsoft.AspNetCore.Mvc;

namespace WebApplicationMVC.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
