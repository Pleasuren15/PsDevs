using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            ViewBag.Careers = new SelectList(_repositoryWrapper._repositoryCareer.FindAll(), "CareerId", "CareerName", null);
            return View();
        }

        [HttpPost]
        public IActionResult Apply(CareerApplication careerApplication)
        {
            if (ModelState.IsValid)
            {
                _repositoryWrapper._repositoryCareerApplication.Create(careerApplication);
                _repositoryWrapper._repositoryCareerApplication.Save();
            }
            return View();
        }
    }
}
