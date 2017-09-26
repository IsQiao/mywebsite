using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mywebsite.Areas.AdminMyWebsite.Controllers
{
    [Area("AdminMyWebsite")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}