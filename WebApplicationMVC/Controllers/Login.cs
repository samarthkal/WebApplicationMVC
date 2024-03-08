using Microsoft.AspNetCore.Mvc;

namespace WebApplicationMVC.Controllers
{
    public class Login : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
