using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Importexcel.Models;

namespace Importexcel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            response model = new response();
            model.answer = "Upload hier uw excel template";
            return View();
        }
    }
}
