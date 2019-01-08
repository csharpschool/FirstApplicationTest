using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var video = new VideoModel()
                { Id = 1, Title = "Shreck" };

            ViewBag.MyData = "My value";

            return View(video);
        }
    }
}