using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PsDevs.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Careers()
        {
            return View();
        }

        public IActionResult Team()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
