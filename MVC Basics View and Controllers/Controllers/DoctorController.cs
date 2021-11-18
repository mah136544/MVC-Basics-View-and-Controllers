using Microsoft.AspNetCore.Mvc;
using MVC_Basics_View_and_Controllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Basics_View_and_Controllers.Controllers
{
    public class DoctorController : Controller
     
    {
        [HttpGet]
        public IActionResult CheckFever()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckFever(float temperature, string tempType)
        {
            string message = "";
            message = Doctor.FeverCheck(temperature, tempType);
            ViewBag.temp = temperature;
            ViewBag.message = message;
            ViewBag.type = tempType;
            return View("FeverResult");
        }
    }
}