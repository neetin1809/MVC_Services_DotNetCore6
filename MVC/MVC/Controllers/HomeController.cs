using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Diagnostics;
using MVC.Services;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISingletonService _singletonService;
        private readonly ITransientService _transientService;
        private readonly IScopedService _scopedService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ITransientService transientService, ISingletonService singleton, IScopedService scoped)
        {
            _logger = logger;
            _transientService = transientService;
            _singletonService = singleton;
            _scopedService = scoped;
        }

        public IActionResult Index()
        {
            //return View();
            return View("Index", _singletonService.GetGuid());

        }

        public IActionResult Scoped()
        {
            return View("Scoped", _scopedService.GetGuid());

        }

        public IActionResult Transient()
        {
            return View("Transient", _transientService.GetGuid());

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