using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PsDevs.Data;
using PsDevs.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PsDevs.Controllers
{
    public class CareerController : Controller
    {
        IRepositoryWrapper _repositoryWrapper { get; set; }

        public CareerController(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }
        public IActionResult Careers()
        {
            return View(_repositoryWrapper._repositoryCareer.FindAll());
        }

        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(CareerApplication careerApplication)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
    }
}
