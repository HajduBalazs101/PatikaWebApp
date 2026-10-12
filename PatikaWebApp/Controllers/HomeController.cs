using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PatikaWebApp.Models;
using PatikaWebApp.Services;

namespace PatikaWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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

        public IActionResult Sajat()
        {
            List<Gyogyszer> gyogyszerek = new GyogyszerService().GetAll();
            return View(gyogyszerek);
        }

        public IActionResult Gyogyszer(int id)
        {
            Gyogyszer gyogyszer = new GyogyszerService().GetById(id);
            return View(gyogyszer);
        }
    }
}
