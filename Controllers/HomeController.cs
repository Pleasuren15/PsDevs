using Microsoft.AspNetCore.Mvc;
using PsDevs.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PsDevs.Controllers
{
    public class HomeController : Controller
    {
        IRepositoryWrapper _repositoryWrapper { get; set; }

        public HomeController(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Careers()
        {
            return View(_repositoryWrapper._repositoryCareer.FindAll());
        }

        public IActionResult Team()
        {
            return View(_repositoryWrapper._repositoryTeamMember.FindAll());
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
