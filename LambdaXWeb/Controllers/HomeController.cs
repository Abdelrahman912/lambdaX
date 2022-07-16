using LambdaXWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LambdaXWeb.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
      
    }
}