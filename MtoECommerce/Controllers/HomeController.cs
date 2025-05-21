using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MtoECommerce.Models;

namespace MtoECommerce.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}
