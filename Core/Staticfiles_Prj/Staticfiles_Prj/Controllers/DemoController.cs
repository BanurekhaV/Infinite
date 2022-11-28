﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Staticfiles_Prj.Models;

namespace Staticfiles_Prj.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DisplayPerson()
        {
            Person person = new Person();
            person.ID = 100;
            person.Name = "Abhinaya";
            return View(person);
        }

        public IActionResult ShowAllMobiles()
        {
            List<string> mobiles = new List<string>()
            {
                "Samsung","Redmi","One Plus","Oppo","Xiomi"
            };
            ViewData["androids"] = mobiles;
            ViewBag.mobilebag = mobiles;
            return View();
        }
    }
}
