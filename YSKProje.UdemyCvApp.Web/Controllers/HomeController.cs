using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Interfaces;
using EntityLayer.Concrete;

namespace YSKProje.UdemyCvApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGenericService<Skill> _skillService;

        public HomeController(IGenericService<Skill> skillService)
        {
            _skillService = skillService;
        }

        public IActionResult Index()
        {

            return View(_skillService.GetAll());
        }
    }
}
