using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Basics_View_and_Controllers.Controllers
{
    public class Projects : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
