using Microsoft.AspNetCore.Mvc;
using SGE.Models;
using System.Diagnostics;

namespace SGE.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Aula()
        {
            return View();
        }

        public IActionResult Maestro()
        {
            return View();
        }

        public IActionResult Alumno()
        {
            return View();
        }

        public IActionResult Calificacion()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
